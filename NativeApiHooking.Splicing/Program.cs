using System;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.Models;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Http.Responses;

namespace NativeApiHooking.Splicing
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            HookDemo.Install();

            var explicitEndpoint = new ExplicitProxyEndPoint(
                ipAddress: IPAddress.Parse("127.0.0.1"),
                port: 8000,
                decryptSsl: true);
            explicitEndpoint.BeforeTunnelConnectRequest += ExplicitEndpoint_BeforeTunnelConnectRequest;

            var proxyServer = new ProxyServer(
                rootCertificateName: "Test certificate",
                rootCertificateIssuerName: "Test certificate issuer",
                userTrustRootCertificate: true,
                machineTrustRootCertificate: false,
                trustRootCertificateAsAdmin: false);

            proxyServer.ForwardToUpstreamGateway = true;
            proxyServer.AddEndPoint(explicitEndpoint);

            proxyServer.BeforeResponse += ProxyServer_BeforeResponse;

            proxyServer.Start();
            proxyServer.SetAsSystemProxy(explicitEndpoint, ProxyProtocolType.AllHttp);

            Console.WriteLine("Proxy started. Press Enter to stop");
            Console.ReadLine();

            proxyServer.RestoreOriginalProxySettings();
            proxyServer.Stop();
            proxyServer.CertificateManager.RemoveTrustedRootCertificate();
        }

        private static Task ExplicitEndpoint_BeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
        {
            string tunnerUrl = e.HttpClient.Request.RequestUri.Host + ":" + e.HttpClient.Request.RequestUri.Port;
            int processId = e.HttpClient.ProcessId.Value;
            string processName = Process.GetProcessById(processId).ProcessName + ":" + processId;
            Console.WriteLine("-> Tunnel to " + tunnerUrl + " " + processName);

            return Task.CompletedTask;
        }

        private static Task ProxyServer_BeforeResponse(object sender, SessionEventArgs e)
        {
            if (e.HttpClient.Request.Host == "stackoverflow.com")
            {
                var response = new RedirectResponse();
                response.Headers.AddHeader("Location", "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                e.Respond(response);
            }

            return Task.CompletedTask;
        }
    }
}
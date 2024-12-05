using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Commvault.Powershell
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class Module
    {
        partial void CustomInit()
        {
            // Add a step at the end of the pipeline to attach the API key
            // Add once for the regular pipeline
            this._pipeline.Append(AddAuthtoken);

            // Add once for the pipeline that supports a proxy
            this._pipelineWithProxy.Append(AddAuthtoken);
        }

        protected async System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> AddAuthtoken(System.Net.Http.HttpRequestMessage request, Runtime.IEventListener callback, Runtime.ISendAsync next)
        {
            try
            {
                // Translate the request URI
                request.RequestUri = TranslateIncomingRequestToCommvaultAPI(request);

                // Check if the URL contains metallic.io
                bool isMetallic = request.RequestUri.AbsoluteUri.ToLower().Contains("metallic.io");

                // Get the authentication token
                var token = System.Environment.GetEnvironmentVariable("CVToken");

                if (string.IsNullOrEmpty(token))
                {
                    throw new Exception("CVToken environment variable is empty or not set.");
                }

                // Add the appropriate authentication header
                if (isMetallic)
                {
                    request.Headers.Add("Authorization", "Bearer " + token);
                }
                else
                {
                    request.Headers.Add("Authtoken", token);
                }

                // Add other necessary headers
                request.Headers.Add("Accept", "application/json");

                // Create a new HttpClient with custom certificate validation
                using (var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (message, cert, certChain, errors) =>
                    {
                        // Check if the certificate is valid
                        if (errors == System.Net.Security.SslPolicyErrors.None)
                            return true;

                        // Check if the certificate is self-signed
                        if (errors == System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors)
                        {
                            var chainPolicy = new X509ChainPolicy();
                            chainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                            chainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;

                            var certChainInstance = new X509Chain();
                            certChainInstance.ChainPolicy = chainPolicy;
                            certChainInstance.Build(cert);

                            // If the certificate is self-signed, trust it
                            if (certChainInstance.ChainStatus.Length == 1 && certChainInstance.ChainStatus[0].Status == X509ChainStatusFlags.UntrustedRoot)
                                return true;
                        }

                        // Reject any other certificate errors
                        return false;
                    }
                })
                using (var client = new HttpClient(handler))
                {
                    // Let the request continue
                    return await client.SendAsync(request, HttpCompletionOption.ResponseContentRead);
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw ex;
            }
        }

        private static System.Uri TranslateIncomingRequestToCommvaultAPI(System.Net.Http.HttpRequestMessage request)
        {
            string removeString = "api";
            int removePos = request.RequestUri.AbsoluteUri.IndexOf(removeString) + removeString.Length;
            string URL = System.Environment.GetEnvironmentVariable("WebServerURL") + request.RequestUri.AbsoluteUri.Remove(0, removePos);

            var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        URL, "\\?&*$|&*$|(\\?)&+|(&)&+", "$1$2"));

            return _url;
        }
    }
}
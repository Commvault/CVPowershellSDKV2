﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace Commvault.Powershell
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class Module
    {
        private static readonly HttpClientHandler _httpClientHandler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                // Check environment variable for SSL verification skip setting
                var skipSSLVerification = System.Environment.GetEnvironmentVariable("SkipSSLVerification");
                return !string.IsNullOrEmpty(skipSSLVerification) && 
                       skipSSLVerification.Equals("true", StringComparison.OrdinalIgnoreCase);
            }
        };

        partial void CustomInit()
        {
            // Create HttpClient with the custom handler
            var httpClient = new HttpClient(_httpClientHandler);
            
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

                // Let the request continue
                return await next.SendAsync(request, callback);
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw;
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
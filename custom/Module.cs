using System;
using System.Collections.Generic;
using System.Text;

namespace Commvault.Powershell
{
    using static Commvault.Powershell.Runtime.Extensions;
    public partial class Module
    {
        partial void CustomInit()
        {
            // we need to add a step at the end of the pipeline 
            // to attach the API key 

            // once for the regular pipeline
            this._pipeline.Append(AddAuthtoken);

            // once for the pipeline that supports a proxy
            this._pipelineWithProxy.Append(AddAuthtoken);
        }

        private static System.Uri TranslateIncomingRequestToCommvaultAPI(System.Net.Http.HttpRequestMessage request)
        {
            string removeString = "api";
            int removePos = request.RequestUri.AbsolutePath.IndexOf(removeString) +removeString.Length;
            string URL = System.Environment.GetEnvironmentVariable("WebServerURL") + request.RequestUri.AbsolutePath.Remove(0, removePos);

            var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        URL, "\\?&*$|&*$|(\\?)&+|(&)&+", "$1$2"));

            return _url;
        }

        protected async System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> AddAuthtoken(System.Net.Http.HttpRequestMessage request, Runtime.IEventListener callback, Runtime.ISendAsync next)
        {

            request.RequestUri = TranslateIncomingRequestToCommvaultAPI(request);
            request.Headers.Add("Authtoken", System.Environment.GetEnvironmentVariable("CVToken"));
            request.Headers.Add("Accept", "application/json");
            // let it go on.
            return await next.SendAsync(request, callback);
        }
    }
}

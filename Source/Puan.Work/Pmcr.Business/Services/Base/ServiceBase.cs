using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Services.Base
{
    public class ServiceBase
    {
        private string _url { get; set; }
        
        public ServiceBase()
        {
#if DEBUG
            _url = "Https://LocalHost:5001";
#else
            _url = "";
#endif
        }

        protected async Task<string> PostAsync(string Uri, string objetoSerializado)
        {
            var _enderece = $"{_url}{Uri}";

            HttpClientHandler clientHansler = new HttpClientHandler();
            clientHansler.ServerCertificateCustomValidationCallback = (sender, caer, chain, sslPolicyErrors) => { return true; };

            using (var client = new HttpClient(clientHansler))
            {
                var content = new StringContent(objetoSerializado, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(_enderece, content);

                if (result.IsSuccessStatusCode)
                {
                    var responseContent = result.Content;
                    string responseString = await responseContent.ReadAsStringAsync();
                    return responseString;
                }

                return null;
            }
        }

    }
}

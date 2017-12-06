using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Cookbook.Services
{
    public abstract class BaseService
    {
        /// <summary>
        /// Obtient le singleton client
        /// </summary>
        protected static HttpClient Client { get { return HttpClientWrapper.Instance; } }
        
        /// <summary>
        /// Classe statique qui gère le singleton du HttpClient
        /// </summary>
        private static class HttpClientWrapper
        {
            private static HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseApiAddress"].ToString())
            };

            /// <summary>
            /// Obtient le client sous forme d'un singleton
            /// </summary>
            public static HttpClient Instance
            {
                get
                {

                    var jsonHeader = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");

                    if (!client.DefaultRequestHeaders.Accept.Contains(jsonHeader))
                        client.DefaultRequestHeaders.Accept.Add(jsonHeader);

                    return client;
                }
            }
        }

    }
}
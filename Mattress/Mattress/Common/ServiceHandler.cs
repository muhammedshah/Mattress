using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mattress.Common
{
    public class ServiceHandler
    {
        /// <summary>
        /// Gets service data from the passed URL.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<string> RequestData(string url)
        {
            HttpClient http = new System.Net.Http.HttpClient();
            HttpResponseMessage response = await http.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }


        /// <summary>
        /// Posting a REST request.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonContent"></param>
        /// <returns></returns>
        public async Task<string> PostRequest(string url, string jsonContent)
        {
            try
            {
                
                HttpClient httpClient = new HttpClient();
                StringContent theContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, theContent);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException hrEx)
            {
                throw hrEx;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

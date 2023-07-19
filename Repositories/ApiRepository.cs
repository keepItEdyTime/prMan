using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using PrGer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace PrGer.Repositories
{
    internal class ApiRepository: IApiRepoitory
    {
        private HttpClient httpClient;

        public ApiRepository()
        {
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri("https://test-reqwest-application.herokuapp.com/");
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.httpClient.DefaultRequestHeaders.Add("APPLICATION-ID", "453f0e4bd91d417b8c68b6c468bf5560");
            this.httpClient.DefaultRequestHeaders.Add("TENANT-ID", "testchallenge");
        }

        public async Task<ProductModel> GetAll()
        {
            var responseString = await this.httpClient.GetStringAsync("products");

            var products = JsonConvert.DeserializeObject<ProductModel>(responseString);
            return products;
        }

        public async Task<int> Add(ProductModel model)
        {
            var  modelJson =  JsonConvert.SerializeObject(model);
            var payLoad = new StringContent(modelJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this.httpClient.PostAsync("products", payLoad).ConfigureAwait(false);
            

            if (!response.IsSuccessStatusCode) { 
                throw new Exception(response.ReasonPhrase);
            }
            
                var resp = await response.Content.ReadAsStringAsync();
                var pr = JsonConvert.DeserializeObject<ProductModelJson>(resp);
                return pr.id;  
        }

        public async Task<ProductModelJson> Update(ProductModel model)
        {
            var modelJson = JsonConvert.SerializeObject(model);
            var payLoad = new StringContent(modelJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this.httpClient.PutAsync("products/"+model.id, payLoad).ConfigureAwait(false); ;
           
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }

            var resp = await response.Content.ReadAsStringAsync();
             return JsonConvert.DeserializeObject<ProductModelJson>(resp);
            
        }

        public async Task<bool> Delete(int id)
        {
            HttpResponseMessage response = await this.httpClient.DeleteAsync("products/"+id).ConfigureAwait(false); ;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }

            return true;
        }
    }
}

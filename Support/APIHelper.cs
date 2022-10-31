using Newtonsoft.Json;
using RestSharp;
using SpecFlowProject1.Support.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    public class APIHelper
    {
        public RestClient restClient;

        public string getBaseUrl()
        {
            string baseUrl;
            return baseUrl = "https://61ea9982c9d96b0017700c47.mockapi.io/";
        }
        public string getEndPoint()
        {
            string endPoint;
            return endPoint = "bakery-awesome/";
        }

        public RestRequest createPostRequest(string payload)
        {
            var restRequest = new RestRequest("/bakery-awesome", Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json",payload,ParameterType.RequestBody);
            return restRequest;

        }

        public RestResponse getResponse(string url) 
        {
            var restRequest = new RestRequest(url, Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            restClient = new RestClient(url);
            var response = restClient.Execute(restRequest);
            var content = response.Content;
            var cakeOrders = JsonConvert.DeserializeObject<CakeOrdersDTO>(content);
            return response;
        }

        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }

    }
}

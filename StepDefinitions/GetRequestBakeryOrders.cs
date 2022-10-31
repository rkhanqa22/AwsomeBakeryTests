using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using SpecFlowProject1.Support;
using SpecFlowProject1.Support.DTO;
using static SpecFlowProject1.Support.DTO.CakeOrdersDTO;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class GetRequestBakeryOrders
    {
        private  APIHelper apiHelper = new APIHelper();
        private  RestClient client = new RestClient();
        private RestResponse response = new RestResponse();
        private RestRequest request = new RestRequest();
        private string uri;

        public GetRequestBakeryOrders(APIHelper apiHelper, RestResponse response)
        {
            this.apiHelper = apiHelper;
            this.response = response;
            this.client = client;
            this.uri = uri;
            this.request = request;
        }

        [When(@"Client able to send request with (.*)")]
        public void WhenClientAbleToSendRequestWith(string id)
        {
            uri = apiHelper.getBaseUrl();
            client = new RestClient(uri+apiHelper.getEndPoint()+id);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
        }

        [Then(@"successful (.*) is recieved")]
        public void ThenSuccessfulIsRecieved(string statusCode)
        {
            response = client.Execute(request);
            Assert.AreEqual(statusCode, response.StatusCode.ToString());   
        }

      
        [Then(@"client with (.*) and ""([^""]*)"" and (.*) and ""([^""]*)"" and (.*) and (.*) and (.*) has been validted")]
        public void ThenClientWithAndAndAndHasBeenValidted(int expectedId, string expectedEmail, string expectedPrice, string expectedcakeName, string expectedId2, string expectedPrice2, string expectedQuantity)
        {
            response = apiHelper.getResponse(uri + apiHelper.getEndPoint() + expectedId);
            var content = response.Content;
            var cakeOrders = JsonConvert.DeserializeObject<CakeOrdersDTO>(content);
            Assert.That(cakeOrders.id, Is.EqualTo(expectedId.ToString()));
            Assert.That(cakeOrders.price, Is.EqualTo(expectedPrice.ToString()));
            Assert.That(cakeOrders.ClientEmail, Is.EqualTo(expectedEmail.ToString()));
            Assert.That(cakeOrders.CakeName, Is.EqualTo(expectedcakeName.ToString()));
            if (expectedId2.Equals("") && expectedPrice2.Equals("") && expectedQuantity.Equals(""))
            {
                Console.WriteLine("Id ,Quantity and Price are not available for this payload!!!");
            }
            else {
                Assert.That(cakeOrders.Id.ToString(), Is.EqualTo(expectedId2.ToString()));
                Assert.That(cakeOrders.Price.ToString(), Is.EqualTo(expectedPrice2.ToString()));
                Assert.That(cakeOrders.Quantity.ToString(), Is.EqualTo(expectedQuantity.ToString()));
            }
            

            Console.WriteLine(cakeOrders.Id);


        }
       



    }
}
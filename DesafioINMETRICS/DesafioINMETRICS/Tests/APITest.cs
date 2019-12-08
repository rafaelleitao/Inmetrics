using System;
using NUnit.Framework;
using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Desafio.Tests
{
    [TestFixture]
    class APITest
    {
        private const string BASE_URL = "http://swapi.co/api/films/";
        [Test]
        public void GetStarWarMoviesTitles()
        {
            // setup do request
            RestClient client = new RestClient(BASE_URL);
            RestRequest request =
                new RestRequest(Method.GET);
            // execução do request
            var response = client.Execute(request);
            // obtem conteudo do response para manipulação
            string rawResponse = response.Content;

            // rawResponse contém json puro
            //parseia string em json
            JObject obj = JObject.Parse(rawResponse);
            //obtem array de results
            var token = (JArray)obj.SelectToken("results");
            //your event logs in list instance
            //itera por cada nó de results para imprimir apenas filmes dirigidos pelo George Lucas e com Rick McCallum na produção 
            foreach (var item in token)
            {
                string title = JsonConvert.SerializeObject(item.SelectToken("title"));
                string producer = JsonConvert.SerializeObject(item.SelectToken("producer"));   
                string director = JsonConvert.SerializeObject(item.SelectToken("director"));
               
                if (director.Contains("George Lucas") && producer.Contains("Rick McCallum"))
                {
                    
                    Console.WriteLine("Diretor: "+director+" Produtor(es): "+producer+" Titulo do Filme : "+title);
                }
            }
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }
        
    }
}

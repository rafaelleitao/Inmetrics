using System;
using NUnit.Framework;
using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using RestSharp.Serialization.Json;
using Desafio.DataTypes;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Desafio.Tests
{
    [TestFixture]
    class APITest
    {
        private const string BASE_URL = "http://swapi.co/api/films/";
        [Test]
        public void RetrieveDataMovies()
        {
            // arrange
            RestClient client = new RestClient(BASE_URL);
            RestRequest request =
                new RestRequest(Method.GET);
            // act
            var response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            string rawResponse = response.Content;

            //your json string
           // string msg = "{\"jsonrpc\":\"2.0\",\"result\":[{\"event\":{\"id\":\"27060267\",\"name\":\"Southampton v West Ham\",\"countryCode\":\"GB\",\"timezone\":\"Europe/London\",\"openDate\":\"2013-09-15T15:00:00.000Z\"},\"marketCount\":69},{\"event\":{\"id\":\"2022802\",\"name\":\"Barclays Premier League\",\"countryCode\":\"GB\",\"timezone\":\"Europe/London\",\"openDate\":\"2013-08-17T11:45:00.000Z\"},\"marketCount\":22},{\"event\":{\"id\":\"27060265\",\"name\":\"Stoke v Man City\",\"countryCode\":\"GB\",\"timezone\":\"Europe/London\",\"openDate\":\"2013-09-14T14:00:00.000Z\"},\"marketCount\":69}]}";
            //convert to json instance
            JObject obj = JObject.Parse(rawResponse);
            //return event array
            var token = (JArray)obj.SelectToken("results");
            //your event logs in list instance
            var list = new List<Result>();
            foreach (var item in token)
            {
                string json = JsonConvert.SerializeObject(item.SelectToken("title"));
                Console.WriteLine(json);
               // list.Add(JsonConvert.DeserializeObject<Result>(json));
            }
          //  Console.Read();






            //Console.WriteLine(rawResponse);
            //Result myClass = new JsonDeserializer().Deserialize<Result>(response);

            // foreach (var item in titles)
            //{
            //    Console.WriteLine(item.ToString());
            // }
            // IRestResponse response = client.Execute(request);
            //  Console.WriteLine(response.ToString());
            //  var jsonObject = JsonConvert.DeserializeObject<RootObject>(response.ToString());
            // StarWarsFilmsResponse FilmsResponse =
            //   new JsonDeserializer().
            //   Deserialize<StarWarsFilmsResponse>(response);

            // Console.WriteLine(FilmsResponse.Title);
            // Console.WriteLine("response "+ FilmsResponse);
            // Extracting output data from received response
            // string conteudo = response.Content;

            // Parsing JSON content into element-node JObject
            //var jObject = JObject.Parse(response.Content);

            //Extracting Node element using Getvalue method
            // string titulo = jObject.GetValue("title").ToString();
            // Let us print the city variable to see what we got
            //Console.WriteLine("titulo " + titulo);

            // Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            // Console.WriteLine(response.StatusCode);





            // assert
            /* Assert.That(
                 StarWarsFilmsResponse.Places[0].PlaceName,
                 Is.EqualTo("Beverly Hills")
             );*/

            /* foreach (var item in FilmsResponse)
             {
                 Console.WriteLine(item);
             }
             Thread.Sleep(3000);*/



        }
        public class Result
        {
            public string title { get; set; }
            public int episode_id { get; set; }
            public string opening_crawl { get; set; }
            public string director { get; set; }
            public string producer { get; set; }
            public string release_date { get; set; }
            public List<string> characters { get; set; }
            public List<string> planets { get; set; }
            public List<string> starships { get; set; }
            public List<object> vehicles { get; set; }
            public List<string> species { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }
        }

        public class RootObject
        {
            public int count { get; set; }
            public object next { get; set; }
            public object previous { get; set; }
            public List<Result> results { get; set; }
        }
    }
}

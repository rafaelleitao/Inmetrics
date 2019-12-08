using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Desafio.DataTypes
{
        public class StarWarsFilmsResponse {
            [JsonProperty("characters")]
            public string Characters { get; set; }

            [JsonProperty("created")]
            public string Created { get; set; }

            [JsonProperty("director")]
            public string Director { get; set; }

            [JsonProperty("edited")]
            public string Edited { get; set; }

            [JsonProperty("episode_id")]
            public string Episode_id { get; set; }

            [JsonProperty("opening_crawl")]
            public string Opening_crawl { get; set; }

            [JsonProperty("planets")]
            public List<String> Planets { get; set; }

            [JsonProperty("producer")]
            public List<String> Producer { get; set; }

            [JsonProperty("release_date")]
            public string Release_date { get; set; }

            [JsonProperty("species")]
            public List<String> Species { get; set; }

            [JsonProperty("starships")]
            public List<String> Starships { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("vehicles")]
            public List<String> Vehicles { get; set; }




    }


}

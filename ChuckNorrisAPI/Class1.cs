using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ChuckNorrisAPI
{
    public class ChuckNorrisClient
    {
        private static HttpClient client;

        static ChuckNorrisClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.icndb.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async static Task<Joke> GetRandomJoke()
        {
            HttpResponseMessage response = await client.GetAsync("jokes/random");

            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ChuckNorrisApiResponse>(await response.Content.ReadAsStringAsync());
                var joke = data.JokeData;
                joke.JokeText = WebUtility.HtmlDecode(joke.JokeText);

                return data.JokeData;
            }
            else
            {
                return null;
            }
        }

        public static IEnumerable<Joke> GetRandomJokes()
        {
            throw new NotImplementedException();
        }

        public static Joke GetJokeById(int id)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
    public class Joke
    {
        public int Id { get; set; }

        [JsonProperty("joke")]
        public string JokeText { get; set; }
        public List<string> Categories { get; set; }
    }

    internal class ChuckNorrisApiResponse
    {
        public string Type { get; set; }

        [JsonProperty("value")]
        public Joke JokeData { get; set; }
    }
}

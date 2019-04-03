using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ChuckNorrisAPI
{
    public class ChuckNorrisClient
    {
        private static readonly HttpClient client;

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
                var data = JsonConvert.DeserializeObject<SingleJokeResponse>(await response.Content.ReadAsStringAsync());
                var joke = data.JokeData;
                joke.JokeText = WebUtility.HtmlDecode(joke.JokeText);

                return data.JokeData;
            }
            else
            {
                return null;
            }
        }

        public async static Task<IEnumerable<Joke>> GetRandomJokes(int numJokes)
        {
            if (numJokes < 1)
                throw new ArgumentException($"{nameof(numJokes)} must be a positive number");

            HttpResponseMessage response = await client.GetAsync($"jokes/random/{numJokes}");

            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<MultiJokeResponse>(await response.Content.ReadAsStringAsync());
                var allJokes = data.Jokes;

                for (int i = 0; i < allJokes.Count(); i++)
                {
                    allJokes.ElementAt(i).JokeText = WebUtility.HtmlDecode(allJokes.ElementAt(i).JokeText);
                }

                return allJokes;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a joke with a specific id
        /// </summary>
        /// <param name="id">The id of the joke to look for</param>
        /// <exception cref="NoSuchQuoteException">Requested quote/joke does not exist</exception>
        /// <returns></returns>
        public async static Task<Joke> GetJokeById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"jokes/{id}");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                try
                {
                    var data = JsonConvert.DeserializeObject<SingleJokeResponse>(result);
                    var joke = data.JokeData;
                    joke.JokeText = WebUtility.HtmlDecode(joke.JokeText);

                    return data.JokeData;
                }
                catch(JsonSerializationException)
                {
                    //this is used when a joke/quote with a specific id cannot be retrieved
                    GeneralResponse generalResponse = JsonConvert.DeserializeObject<GeneralResponse>(result);

                    if (generalResponse.Type != "success")
                        throw new NoSuchQuoteException($"{generalResponse.Type}. A joke with an id of {id} does not exist");
                }
            }

            return null;
        }

        public async static Task<IEnumerable<string>> GetCategories()
        {
            HttpResponseMessage response = await client.GetAsync($"categories");

            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<CategoriesResponse>(await response.Content.ReadAsStringAsync());
                return data.Categories;
            }
            else
            {
                return null;
            }
        }
    }
}

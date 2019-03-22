using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ChuckNorrisAPI
{
    public class ChuckNorrisClient
    {
        private static HttpClient client;

        public static void GetRandomJoke()
        {
            throw new NotImplementedException();
        }

        public class Joke
        {
            public int Id { get; set; }
            public string JokeText { get; set; }
            public List<string> Categories { get; set; }
        }

        public class WebResponse
        {
            public string Type { get; set; }
            public Joke Value { get; set; }
        }
    }
}

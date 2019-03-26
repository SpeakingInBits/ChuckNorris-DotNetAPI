using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisAPI
{
    internal class GeneralResponse
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }

    internal class SingleJokeResponse
    {
        public string Type { get; set; }

        [JsonProperty("value")]
        public Joke JokeData { get; set; }
    }

    internal class MultiJokeResponse
    {
        public string Type { get; set; }

        [JsonProperty("value")]
        public IEnumerable<Joke> Jokes { get; set; }
    }

    internal class CategoriesResponse
    {
        public string Type { get; set; }

        [JsonProperty("value")]
        public string[] Categories { get; set; }
    }
}

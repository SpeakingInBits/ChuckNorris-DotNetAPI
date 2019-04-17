using System;
using static System.Console;
using ChuckNorrisAPI;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ApiTester
{
    class Program
    {
        static void Main()
        {
            Run().Wait();
        }

        private static async Task Run()
        {
            //get random joke test
            WriteLine("Getting a single joke**********************");
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            WriteLine($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");

            //get categories
            WriteLine("Getting categories****************************");
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                WriteLine(cat);
            }

            //print specific joke
            WriteLine("Getting specific joke***************************");
            Joke j2 = await ChuckNorrisClient.GetJokeById(2);
            WriteLine(j2.JokeText);

            //retrieve joke that doesn't exist
            WriteLine("Retrieving non-existent joke********************");
            try
            {
                Joke j3 = await ChuckNorrisClient.GetJokeById(20000000);
            }
            catch (NoSuchQuoteException)
            {
                WriteLine("There is no joke/quote with that id");
            }


            ReadKey();
        }
    }
}

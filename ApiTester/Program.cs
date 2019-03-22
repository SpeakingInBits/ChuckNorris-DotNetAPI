using System;
using static System.Console;
using ChuckNorrisAPI;
using System.Threading.Tasks;

namespace ApiTester
{
    class Program
    {
        static async Task Main()
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            WriteLine($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");
            ReadKey();
        }
    }
}

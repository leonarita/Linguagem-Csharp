using System;
using System.Threading.Tasks;

namespace _43_Multi_threading__async_e_await_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Program p = new Program();
            await p.MakeFood("Steak");
        }

        public async Task MakeFood (string foodItem)
        {
            Console.WriteLine($"Preparing {foodItem}");
            await Task.Delay(5000);
            Console.WriteLine($"{foodItem} is ready!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _42_Http_Client
{
    class Program
    {
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();

            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("http://jsonplaceholder.typicode.com/todos");
            
            //Print JSON returns by the site
            Console.WriteLine(response);

            List<Todo> todo = JsonConvert.DeserializeObject<List<Todo>>(response);

            foreach (var item in todo)
                Console.WriteLine(item.title);
        }
    }

    //JSON Parsing -> Install Newtonsoft.Json in nugget
    class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}

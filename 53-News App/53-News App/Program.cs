using Newtonsoft.Json;
using ServiceStack.Auth;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace _53_News_App
{
    class Program
    {
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program p = new Program();

            await p.GetArticles();
        }

        private async Task GetArticles()
        {
        //    string response = await client.GetStringAsync($"https://newsapi.org/v2/top-headlines?country=us&apiKey={ApiKey.APIKEY}");

            NewsResponse newObject = JsonConvert.DeserializeObject<NewsResponse>(response);

            foreach(var article in newObject.Articles)
            {
                Console.WriteLine(article.Title);
                Console.WriteLine();
            }

            Console.WriteLine("What article would you like to read?");
            var index = Convert.ToInt32(Console.ReadLine());

            for (var i=0; i<newObject.Articles.Count; i++)
            {
                if (i==index)
                {
                    Console.WriteLine(newObject.Articles[i].Content);
                }
            }
        }
    }

    class NewsResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

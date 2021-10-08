using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Apator.GitHub.Interview.Helper
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task Main()
        {
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Bearer", "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"));
            var response = await client.GetAsync("/licenses");
            Console.WriteLine("Status code: ");
            Console.WriteLine(response.StatusCode);
            Console.WriteLine("Content: ");
            string x = await response.Content.ReadAsStringAsync();
            Console.WriteLine(x);
        }
    }
}

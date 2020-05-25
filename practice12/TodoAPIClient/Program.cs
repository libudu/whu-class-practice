using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TodoApi.Models;

namespace TodoAPIClient
{
    class Program{

        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            string baseUrl="https://localhost:5001/api/todo";

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = delegate { return true; };

            HttpClient client=new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            TodoItem todo=new TodoItem(){Id=50,Name="软件构造基础",IsComplete=false};
            HttpContent content = new StringContent(JsonConvert.SerializeObject(todo), Encoding.UTF8,"application/json");
            var task=client.PostAsync(baseUrl,content);
            task.Wait();
            
            var task2 = client.GetStringAsync(baseUrl);
            List<TodoItem> todos = JsonConvert.DeserializeObject<List<TodoItem>>(task2.Result);
            todos.ForEach(t=>Console.WriteLine($"{t.Id},{t.Name},{t.IsComplete}"));
        }
    }

}

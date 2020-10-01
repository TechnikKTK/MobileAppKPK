using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KpKApp1.RestAPI
{
    public static class RestApi
    {
        public static async Task<List<Person>> GetUsers()
        {
            try
            {
                var str_url = "http://www.webapikamtk.somee.com/api/Test";
                //var str_url = "http://dummy.restapiexample.com/api/v1/employees";
                var url = new Uri(str_url);

                HttpClient client = new HttpClient();
                client.BaseAddress = url;
                var response = await client.GetAsync(client.BaseAddress).ConfigureAwait(continueOnCapturedContext: false);

                response.EnsureSuccessStatusCode(); // выброс исключения, если произошла ошибка

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    
                    var result = JsonConvert.DeserializeObject<List<Person>>(json);
                    
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception er)
            { 
                return null; 
            }
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool Registered { get; set; }
    }
}

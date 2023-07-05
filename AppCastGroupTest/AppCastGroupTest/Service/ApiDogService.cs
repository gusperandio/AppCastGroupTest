using AppCastGroupTest.Service.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppCastGroupTest.Service
{
    public class ApiDogService
    {
        private static string url = "https://dog.ceo/api/breeds/image/random";

        public static async Task<Dogs> GetDogs()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(url);

                Dogs dogs = JsonConvert.DeserializeObject<Dogs>(content);
                return dogs;
            }
        }
    }
}

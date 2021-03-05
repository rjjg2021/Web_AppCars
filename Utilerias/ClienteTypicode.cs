using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Web_AppCars.Models;

namespace Web_AppCars.Utilerias
{
    public class ClienteTypicode
    {
        public readonly HttpClient cliente;

        public ClienteTypicode()
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json").Build();

            var apiURL = config.GetSection("ApiURL").Value;


            cliente = new HttpClient
            {
                BaseAddress = new Uri(apiURL)
            };

            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }


        public async Task<List<Car>> ListCars()
        {
            List<Car> cars = new List<Car>();
            try
            {
                cars = await cliente.GetFromJsonAsync<List<Car>>("test/carsdata");
            }
            catch (Exception ex)
            {

                Console.Write($"Error: {ex.Message}");
            }

            return cars;

        }
    }
}

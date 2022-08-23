using System.Threading.Tasks;
using RestSharp;
using System;
using System.Collections.Generic;

namespace StarTrekDash.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllArticles()
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
      RestRequest request = new RestRequest($"world.json?api-key=rIRXqv5I1wGtzAaNZGDPaQ11A5UDX3so", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    
    public static async Task<string> GetAllWeather()
    {
      RestClient client = new RestClient("https://api.openweathermap.org/data/2.5/");
      RestRequest request = new RestRequest("$weather?q=portland,oregon&appid=1c1b98fa298118950e0f4b736fb9f1a6", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}
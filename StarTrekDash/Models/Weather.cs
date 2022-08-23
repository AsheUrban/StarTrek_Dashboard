using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StarTrekDash.Models
{
  public class Weather
  {
    
    public string Temp { get; set; }
    public  string Feels_Like { get; set; }
  
  
    public static Weather GetWeather()
    {
      var apiCallTask = ApiHelper.GetAllWeather();
      var resultWeather = apiCallTask.Result;
      
      var weather = JsonConvert.DeserializeObject<Weather>(resultWeather);
      
      //JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(resultWeather);
     // Weather weather = JsonConvert.DeserializeObject<Weather>(jsonResponse["resultWeathers"].ToString());
      return weather;
    }
  }
}
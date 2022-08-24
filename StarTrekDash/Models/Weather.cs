using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace StarTrekDash.Models
{
  public class Weather
  {
    public int clouds { get; set; }
    // public string wind_cdir {get; set;}
    // public 

    
    public static List<Weather> get_Weather()
    {
      var apiCallTask = ApiHelper.GetAllWeather();
      var weatherResult = apiCallTask.Result;
     
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(weatherResult);
       Console.WriteLine(jsonResponse);
       List<Weather> WeatherInfo = JsonConvert.DeserializeObject<List<Weather>>(jsonResponse["data"].ToString());
    
      return WeatherInfo;
    }
  }
  
}
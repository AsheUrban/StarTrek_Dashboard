using System.Collections.Generic;
using System;
using System.Globalization;
using System.Runtime;


namespace StarTrekDash.Models
{
	public class Date 
	{
  // public static string get_Now()
  // {
    // int year = Now.Year;
    // int month = Now.Month;
    // int day = Now.Day;
    // int hour = Now.Hour;
    // int min = Now.Minute;
    // int sec = Now.Second;
//     string time = new (DateTime.Now.ToString("HH:mm:ss "));
//     string date = new (DateTime.Now.ToString("yyyy-MM-dd"));
// var starDate = 
// starDate = starDate / (1000 * 60 * 60 * 24 * 0.036525 );
// starDate = starDate/ 10;
// return starDate;



		// var date =  DateTime.Now.ToUniversalTime() -  new DateTime(1987, 07, 18 );
		// var stardate = date / (1000 * 60 * 60 * 24 * 0.036525);
		// stardate = Math.Floor(stardate + 410000);
		// stardate = stardate/ 10;

    //  string timeString = (time.ToString() + stardate.ToString());
    // return timeString;

    // }
	
  
    public static double Stardate()
    {
      DateTime calendar = new DateTime(1987, 07, 18);
      DateTime localTime = DateTime.Now;
      localTime = localTime.AddYears(377);
      TimeSpan timeOffSet = localTime - calendar;
      double yearValue = timeOffSet.TotalMilliseconds / (60 * 60 * 24 * 365.2422);
      double stardate = Math.Floor(yearValue * 100);
      stardate = stardate / 100;
      return stardate;
    }
  }
}

//
// var now = new Date();
// var then = new Date("July 15, 1987");
// var stardate = now.getTime() - then.getTime();
// stardate = stardate / (1000 * 60 * 60 * 24 * 0.036525);
// stardate = Math.floor(stardate + 410000);
// stardate = stardate / 10
// document.write("Today is Stardate " + stardate);

//  var time = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1));
//    return (int)(time.TotalMilliseconds + 0.5);




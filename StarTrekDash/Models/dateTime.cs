using System.Collections.Generic;
using System;
using System.Globalization;
using System.Runtime;


namespace StarTrekDash.Models
{
	public class StarDate 
	{
  public static string get_Time()
	{
    string time = new (DateTime.Now.ToString("HH:mm:ss"));
		return "Time: " + time;
	}
	public static string get_StarDate()
	{
		string date = new (DateTime.Today.ToString("MM-dd-yyyy"));

		//math for star date
		string dayOfWeek = new (DateTime.Today.DayOfWeek.ToString());
		return dayOfWeek + "            " + date;
		// string resultString = Regex.Match(date, @"\d+").Value;
		// var datenum = Int32.Parse(resultString);
		// return datenum;


	}

	}
	}

	
  
    // public static double Stardate()
    // {
    //   DateTime calendar = new DateTime(1987, 07, 18);
    //   DateTime localTime = DateTime.Now;
    //   localTime = localTime.AddYears(64);
    //   TimeSpan timeOffSet = localTime - calendar;
    //   double yearValue = timeOffSet.TotalMilliseconds / (60 * 60 * 24 * 365.2422);;
    //   double stardate = Math.Floor(yearValue * 100);
    //   stardate = stardate / 100;
    //   return stardate;
    // }



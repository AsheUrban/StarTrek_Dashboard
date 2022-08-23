using System.Collections.Generic;
using System;
using System.Globalization;
using System.Runtime;


namespace StarTrekDash.Models
{
	public class StarDate 
	{
  public static double get_Now()
	{
    string time = new (DateTime.Now.ToString("HH:mm:ss"));
    double date = DateTime.Now.ToOADate();
		double starDate = date / 1000 * 60 * 60 * 24 * 0.036525 ;
		var starDate1 = Math.Floor(starDate + 410000);
		double starDate2 = starDate1/ 10;
		return starDate2;

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
  }}






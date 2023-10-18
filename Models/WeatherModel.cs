﻿namespace WeatherApp.Models
{

    public class WeatherModel
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units current_units { get; set; }
        public Current current { get; set; }
        public Hourly_Units hourly_units { get; set; }
        public Hourly hourly { get; set; }
        public Daily_Units daily_units { get; set; }
        public Daily daily { get; set; }
    }

    public class Current_Units
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string weathercode { get; set; }
        public string windspeed_10m { get; set; }
        public string winddirection_10m { get; set; }
    }

    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float temperature_2m { get; set; }
        public int weathercode { get; set; }
        public float windspeed_10m { get; set; }
        public int winddirection_10m { get; set; }
    }

    public class Hourly_Units
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Hourly
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
    }

    public class Daily_Units
    {
        public string time { get; set; }
        public string weathercode { get; set; }
        public string apparent_temperature_max { get; set; }
        public string apparent_temperature_min { get; set; }
    }

    public class Daily
    {
        public string[] time { get; set; }
        public int[] weathercode { get; set; }
        public float[] apparent_temperature_max { get; set; }
        public float[] apparent_temperature_min { get; set; }
    }

}
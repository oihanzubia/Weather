namespace WeatherApp
{
    public class Endpoints
    {
        public static string GetGeoApifyEndpoint(string cityName)
        {
            return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoApifyKey}";
            //return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=YOUR_API_KEY";
        }
        public static string GetWeatherEndpoint(float lat, float lon) 
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,weathercode,windspeed_10m,winddirection_10m&hourly=temperature_2m&daily=weathercode,apparent_temperature_max,apparent_temperature_min&timezone=Europe%2FLondon";
            //var url = $"https://api.open-meteo.com/v1/forecast?latitude=52.5244&longitude=13.4105&&current=temperature_2m,weathercode,windspeed_10m,winddirection_10m&hourly=temperature_2m&daily=weathercode,apparent_temperature_max,apparent_temperature_min&timezone=Europe%2FLondon"
            return url;
        }
    }
}

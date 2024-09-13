using System;
using System.Device.Location;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace WeatherFormsApp
{
    /// <summary>
    /// Class to handle all API requests for the Weather Data.
    /// </summary>
    internal class WeatherDataApi
    {
        private static readonly Utils utils = new Utils();

        /// <summary>
        /// Represents the API Key.
        /// </summary>
        /// <see cref="Properties.Resources.config___example"/>
        /// <remarks>In the config.xml file you will need to replace the example text with your API key.</remarks>
        private string WeatherbitApiKey;


        public WeatherDataApi()
        {
            WeatherbitApiKey = utils.LoadApiKey("config.xml");
        }

        /// <summary>
        /// Gets the current computer's latitude.
        /// </summary>
        public string GetLatitude()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            string latitude = "Location is unknown.";

            watcher.PositionChanged += (sender, e) =>
            {
                GeoCoordinate coord = e.Position.Location;
                if (!coord.IsUnknown)
                {
                    latitude = coord.Latitude.ToString();
                }
                watcher.Stop();
            };

            watcher.Start();
            return latitude;
        }

        /// <summary>
        /// Gets the current computer's longitude.
        /// </summary>
        public string GetLongitude()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            string longitude = "Location is unknown.";

            watcher.PositionChanged += (sender, e) =>
            {
                GeoCoordinate coord = e.Position.Location;
                if (!coord.IsUnknown)
                {
                    longitude = coord.Longitude.ToString();
                }
                watcher.Stop();
            };

            watcher.Start();
            return longitude;
        }

        /// <summary>
        /// Gets current weather data.
        /// </summary>
        /// <returns>CurrentWeather object</returns>
        public CurrentWeather GetCurrentWeather()
        {
            string latitude = "49.895138"; //GetLatitude();
            string longitude = "-97.138374"; //GetLongitude();
            string url = $"https://api.weatherbit.io/v2.0/current?lat={latitude}&lon={longitude}&key={WeatherbitApiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var serializer = new DataContractJsonSerializer(typeof(CurrentWeather));
                    var stream = response.Content.ReadAsStreamAsync().Result;
                    var weatherData = (CurrentWeather)serializer.ReadObject(stream);
                    return weatherData;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve weather data.");
                    return null;
                }
            }
        }

    }
}
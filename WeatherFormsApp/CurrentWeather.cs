using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class CurrentWeather
{
    [DataMember(Name = "count")]
    public int Count { get; set; }

    [DataMember(Name = "data")]
    public List<WeatherData> Data { get; set; }

    [DataContract]
    public class WeatherData
    {
        [DataMember(Name = "app_temp")]
        public float AppTemp { get; set; }

        [DataMember(Name = "aqi")]
        public int Aqi { get; set; }

        [DataMember(Name = "city_name")]
        public string CityName { get; set; }

        [DataMember(Name = "clouds")]
        public int Clouds { get; set; }

        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        [DataMember(Name = "datetime")]
        public string Datetime { get; set; }

        [DataMember(Name = "dewpt")]
        public float Dewpt { get; set; }

        [DataMember(Name = "dhi")]
        public float Dhi { get; set; }

        [DataMember(Name = "dni")]
        public float Dni { get; set; }

        [DataMember(Name = "elev_angle")]
        public float ElevAngle { get; set; }

        [DataMember(Name = "ghi")]
        public float Ghi { get; set; }

        [DataMember(Name = "gust")]
        public float Gust { get; set; }

        [DataMember(Name = "h_angle")]
        public float HAngle { get; set; }

        [DataMember(Name = "lat")]
        public float Lat { get; set; }

        [DataMember(Name = "lon")]
        public float Lon { get; set; }

        [DataMember(Name = "ob_time")]
        public string ObTime { get; set; }

        [DataMember(Name = "pod")]
        public string Pod { get; set; }

        [DataMember(Name = "precip")]
        public float Precip { get; set; }

        [DataMember(Name = "pres")]
        public float Pres { get; set; }

        [DataMember(Name = "rh")]
        public int Rh { get; set; }

        [DataMember(Name = "slp")]
        public float Slp { get; set; }

        [DataMember(Name = "snow")]
        public float Snow { get; set; }

        [DataMember(Name = "solar_rad")]
        public float SolarRad { get; set; }

        [DataMember(Name = "sources")]
        public List<string> Sources { get; set; }

        [DataMember(Name = "state_code")]
        public string StateCode { get; set; }

        [DataMember(Name = "station")]
        public string Station { get; set; }

        [DataMember(Name = "sunrise")]
        public string Sunrise { get; set; }

        [DataMember(Name = "sunset")]
        public string Sunset { get; set; }

        [DataMember(Name = "temp")]
        public float Temp { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }

        [DataMember(Name = "ts")]
        public long Ts { get; set; }

        [DataMember(Name = "uv")]
        public float Uv { get; set; }

        [DataMember(Name = "vis")]
        public float Vis { get; set; }

        [DataMember(Name = "weather")]
        public WeatherDescription Weather { get; set; }

        [DataMember(Name = "wind_cdir")]
        public string WindCdir { get; set; }

        [DataMember(Name = "wind_cdir_full")]
        public string WindCdirFull { get; set; }

        [DataMember(Name = "wind_dir")]
        public int WindDir { get; set; }

        [DataMember(Name = "wind_spd")]
        public float WindSpd { get; set; }
    }

    [DataContract]
    public class WeatherDescription
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("tempC")]
        public double TempC { get; set; }

        [JsonProperty("tempF")]
        public double TempF { get; set; }

        [JsonProperty("windMph")]
        public double WindMph { get; set; }

        [JsonProperty("windKph")]
        public double WindKph { get; set; }

        [JsonProperty("windDegree")]
        public int WindDegree { get; set; }

        [JsonProperty("windDir")]
        public string WindDir { get; set; }

        [JsonProperty("pressureMb")]
        public int PressureMb { get; set; }

        [JsonProperty("pressureIn")]
        public double PressureIn { get; set; }

        [JsonProperty("precipMm")]
        public int PrecipMm { get; set; }

        [JsonProperty("precipIn")]
        public int PrecipIn { get; set; }

        [JsonProperty("feelslikeC")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslikeF")]
        public double FeelslikeF { get; set; }

        [JsonProperty("visKm")]
        public int VisKm { get; set; }

        [JsonProperty("visMiles")]
        public int VisMiles { get; set; }

        [JsonProperty("gustMph")]
        public double GustMph { get; set; }

        [JsonProperty("gustKph")]
        public double GustKph { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}

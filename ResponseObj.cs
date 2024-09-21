using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("tempC")]
    public double tempC { get; set; }

    [JsonProperty("tempF")]
    public int tempF { get; set; }

    [JsonProperty("windMph")]
    public double windMph { get; set; }

    [JsonProperty("windKph")]
    public double windKph { get; set; }

    [JsonProperty("windDegree")]
    public int windDegree { get; set; }

    [JsonProperty("windDir")]
    public string windDir { get; set; }

    [JsonProperty("pressureMb")]
    public int pressureMb { get; set; }

    [JsonProperty("pressureIn")]
    public double pressureIn { get; set; }

    [JsonProperty("precipMm")]
    public int precipMm { get; set; }

    [JsonProperty("precipIn")]
    public int precipIn { get; set; }

    [JsonProperty("feelslikeC")]
    public double feelslikeC { get; set; }

    [JsonProperty("feelslikeF")]
    public int feelslikeF { get; set; }

    [JsonProperty("visKm")]
    public int visKm { get; set; }

    [JsonProperty("visMiles")]
    public int visMiles { get; set; }

    [JsonProperty("gustMph")]
    public double gustMph { get; set; }

    [JsonProperty("gustKph")]
    public double gustKph { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class location
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("lat")]
    public double lat { get; set; }

    [JsonProperty("lon")]
    public double lon { get; set; }

    [JsonProperty("tz_id")]
    public string tzid { get; set; }

    [JsonProperty("localtime_epoch")]
    public int localtimeepoch { get; set; }

    [JsonProperty("localtime")]
    public string localtime { get; set; }

}

public class current
{
    [JsonProperty("tempC")]
    public double tempC { get; set; }

    [JsonProperty("tempF")]
    public double tempF { get; set; }

    [JsonProperty("windMph")]
    public double windMph { get; set; }

    [JsonProperty("windKph")]
    public int windKph { get; set; }

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
    public double feelslikeF { get; set; }

    [JsonProperty("visKm")]
    public int visKm { get; set; }

    [JsonProperty("visMiles")]
    public int visMiles { get; set; }

    [JsonProperty("gustMph")]
    public double gustMph { get; set; }

    [JsonProperty("gustKph")]
    public int gustKph { get; set; }

}

public class condition
{
    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

public class day
{
    [JsonProperty("maxtemp_c")]
    public double maxtempc { get; set; }

    [JsonProperty("maxtemp_f")]
    public double maxtempf { get; set; }

    [JsonProperty("mintemp_c")]
    public double mintempc { get; set; }

    [JsonProperty("mintemp_f")]
    public int mintempf { get; set; }

    [JsonProperty("avgtemp_c")]
    public double avgtempc { get; set; }

    [JsonProperty("avgtemp_f")]
    public double avgtempf { get; set; }

    [JsonProperty("maxwind_mph")]
    public int maxwindmph { get; set; }

    [JsonProperty("maxwind_kph")]
    public double maxwindkph { get; set; }

    [JsonProperty("totalprecip_mm")]
    public double totalprecipmm { get; set; }

    [JsonProperty("totalprecip_in")]
    public int totalprecipin { get; set; }

    [JsonProperty("totalsnow_cm")]
    public int totalsnowcm { get; set; }

    [JsonProperty("avgvis_km")]
    public int avgviskm { get; set; }

    [JsonProperty("avgvis_miles")]
    public int avgvismiles { get; set; }

    [JsonProperty("avghumidity")]
    public int avghumidity { get; set; }

    [JsonProperty("daily_will_it_rain")]
    public int dailywillitrain { get; set; }

    [JsonProperty("daily_chance_of_rain")]
    public int dailychanceofrain { get; set; }

    [JsonProperty("daily_will_it_snow")]
    public int dailywillitsnow { get; set; }

    [JsonProperty("daily_chance_of_snow")]
    public int dailychanceofsnow { get; set; }

    [JsonProperty("condition")]
    public condition condition { get; set; }

    [JsonProperty("uv")]
    public int uv { get; set; }

}

public class forecastday
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("date_epoch")]
    public int dateepoch { get; set; }

    [JsonProperty("day")]
    public day day { get; set; }

}

public class forecast
{
    [JsonProperty("forecastday")]
    public forecastday[] forecastday { get; set; }

}

public class data
{
    [JsonProperty("location")]
    public location location { get; set; }

    [JsonProperty("current")]
    public current current { get; set; }

    [JsonProperty("forecast")]
    public forecast forecast { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}

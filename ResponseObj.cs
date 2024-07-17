using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class location1
{
    [JsonProperty("latitude")]
    public string latitude { get; set; }

    [JsonProperty("longitude")]
    public string longitude { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

}

public class location2
{
    [JsonProperty("latitude")]
    public string latitude { get; set; }

    [JsonProperty("longitude")]
    public string longitude { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

}

public class data
{
    [JsonProperty("distanceMiles")]
    public double distanceMiles { get; set; }

    [JsonProperty("distanceKm")]
    public double distanceKm { get; set; }

    [JsonProperty("location1")]
    public location1 location1 { get; set; }

    [JsonProperty("location2")]
    public location2 location2 { get; set; }

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

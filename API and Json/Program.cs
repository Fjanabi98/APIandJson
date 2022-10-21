using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Diagnostics.Metrics;
//using static System.Net.WebRequestMethods;

var client = new HttpClient();
var cityName = "Sterling Heights";
var apiKey = "a4f2a02c2bc9065d51921c2712028703";
var geocodingURL = $"http://api.openweathermap.org/data/2.5/forecast?q={cityName}&units=imperial&appid={apiKey}";
var response = client.GetStringAsync(geocodingURL).Result;

var jsonObj = JsonConvert.DeserializeObject<JObject>(response);

var test = jsonObj["list"];

foreach (var item in test)
{
    Console.WriteLine(item["main"]["temp"]);
    Console.WriteLine();
}

//var responseWeather = JObject.Parse(response).GetValue("main").ToString();
////Console.WriteLine($"{{JObject.Parse(responseWeather).GetValue(\"temp\")}}");
//Console.WriteLine(responseWeather);



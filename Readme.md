Distance Calculator API
============

Distance Calculator is a simple tool for calculating the distance between two locations. It returns the distance in miles and kilometers.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Distance Calculator API](https://apiverve.com/marketplace/api/distancecalculator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.DistanceCalculator
```

Using the Package Manager:
```
nuget install APIVerve.API.DistanceCalculator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.DistanceCalculator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.DistanceCalculator".
5. Click on the APIVerve.API.DistanceCalculator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the distancecalculator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Distance Calculator API documentation is found here: [https://docs.apiverve.com/api/distancecalculator](https://docs.apiverve.com/api/distancecalculator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Distance Calculator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new DistanceCalculatorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new distancecalculatorQueryOptions {
  lat1 = 36.7783,
  lon1 = -119.4179,
  lat2 = 34.0522,
  lon2 = -118.2437
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response.data, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "distanceMiles": 199.6804337234997,
    "distanceKm": 321.25354627586279,
    "location1": {
      "latitude": "36.728450",
      "longitude": "-119.53571",
      "city": "Sanger",
      "state": "California"
    },
    "location2": {
      "zipcode": "90013",
      "latitude": "34.044662",
      "longitude": "-118.24255",
      "city": "Los Angeles",
      "state": "California"
    }
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
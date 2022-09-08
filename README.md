# GraphAlgorithms

I used API data from data.transportation.gov (https://data.transportation.gov/resource/4f3n-jbg2.json?year=2021) to read in some price flight information to find the cheapest flights between cities. The data is returned as JSON. I used the Newtonsoft.Json package to Deserialize the JSON Object into a string so I could use the JSON data in .NET. I created a loop through the stack of objects to find Direct Flights. I used a variation of Depth-First Search using a Stack for the connecting flights.

![](https://user-images.githubusercontent.com/83522315/189015086-965eb2da-4807-4fb8-886f-e59805701557.PNG)

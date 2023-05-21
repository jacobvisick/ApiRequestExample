This app gets 3 random facts from an animal facts API. They aren't always good facts, since they
can be user submitted, but this link is the documentation for the free API:

https://alexwohlbruck.github.io/cat-facts/docs/

First, check out Models/AnimalFact.cs to see the model that represents the JSON response from an API

Then, check out AnimalFactsService to see how to use HttpClient to send a request, receive a response,
and turn the JSON into a C# object
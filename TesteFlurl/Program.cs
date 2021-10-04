using Flurl;
using Flurl.Http;
using System;
using TesteFlurl.Models;

var url = "https://pokeapi.co/api/v2/pokemon";

var result = await url.SetQueryParams(new { limit = 5 })
                      .GetJsonAsync<NamedAPIResourceList>();

Console.WriteLine("Resultados:");

var color = new Random().Next(0, 15);

Console.ForegroundColor = (ConsoleColor)color;

foreach (var item in result.Results)
    Console.WriteLine($"Name: {item.Name} <---> Url: {item.Url}");

Console.ResetColor();

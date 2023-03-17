// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

var configValue = config.GetSection("Setting:Message");

Console.WriteLine(configValue.Value);
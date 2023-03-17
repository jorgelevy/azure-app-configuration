using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

int keyOneValue = config.GetValue<int>("KeyOne");
bool keyTwoValue = config.GetValue<bool>("KeyTwo");
string? keyThreeNestedValue = config.GetValue<string>("KeyThree:Message");

Console.WriteLine($"KeyOne = {keyOneValue}");
Console.WriteLine($"KeyTwo = {keyTwoValue}");
Console.WriteLine($"KeyThree:Message = {keyThreeNestedValue}");

//await host.RunAsync();
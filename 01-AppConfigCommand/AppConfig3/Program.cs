using AppConfig3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

Console.WriteLine(settings.KeyThree.Message);

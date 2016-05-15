using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
				.AddXmlFile("appsettings.xml")
				.AddIniFile("appsettings.ini");

            builder.AddEnvironmentVariables();
            IConfigurationRoot Configuration = builder.Build();
			
            Console.WriteLine("Read json configuration file: " + Configuration["JsonData:DefaultConnection:ConnectionString"]);
			Console.WriteLine(".");
			Console.WriteLine(".");
			Console.WriteLine("Read xml configuration file: ");
			Console.WriteLine("Xml node content: " + Configuration["DefaultConnection"]);
			Console.WriteLine("Xml node attribute 1: " + Configuration["DefaultConnection:key"]);
			Console.WriteLine("Xml node attribute 2: " + Configuration["DefaultConnection:value"]);
			Console.WriteLine(".");
			Console.WriteLine(".");
			Console.WriteLine("Read ini configuration file: " + Configuration["IniData:DefaultConnection"]);
        }
    }
}

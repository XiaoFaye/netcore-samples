using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    var host = new WebHostBuilder()
                        .UseKestrel()
						.UseUrls("http://www.binding1.co.nz:5100;http://www.binding2.co.nz:5200")
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseIISIntegration()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}

using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    var host = new WebHostBuilder()
                        .UseWebListener()
						.UseUrls("http://www.binding1.co.nz:80;http://www.binding2.co.nz:80")
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Reflection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var assembly = Assembly.GetEntryAssembly();
			
			Console.WriteLine("All embedded resources:");
			foreach(string name in assembly.GetManifestResourceNames())
			{
				Console.WriteLine(name);
				var resourceStream = assembly.GetManifestResourceStream(name);
				if(Path.GetExtension(name).ToLower() == ".txt")
				{
					using (var reader = new StreamReader(resourceStream))
					{
						Console.WriteLine("Resource content:" + reader.ReadToEnd());
						Console.WriteLine("Resource size:" + reader.BaseStream.Length.ToString() + " bytes.");
					}
				}
				else
				{
					using (var reader = new BinaryReader(resourceStream))
					{
						Console.WriteLine("Resource size:" + reader.BaseStream.Length.ToString() + " bytes.");
					}
				}	
				
				
				
			}
        }
    }
}

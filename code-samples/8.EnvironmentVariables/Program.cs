using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
			List<string> vars = new List<string>();
			
			foreach (var key in Environment.GetEnvironmentVariables().Keys)
			{
				vars.Add(key + ": ");
			}
			
			int i = 0;
			foreach (var value in Environment.GetEnvironmentVariables().Values)
			{
				vars[i] += value;
				i++;
			}
			
			foreach(string v in vars)
				Console.WriteLine(v);
        }
    }
}

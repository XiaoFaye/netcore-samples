using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            IConfigurationRoot Configuration = builder.Build();
			
			string message = string.Empty;
			using (SqlConnection conn = new SqlConnection(Configuration["Data:DefaultConnection:ConnectionString"]))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT @@version;", conn))
                    {
                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            message = result.ToString();

                        conn.Close();
                    }
                }
                catch(Exception ex)
                {
                    message = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
			
			Console.WriteLine("Connect to SQL Server: \n\r" + message);
        }
    }
}

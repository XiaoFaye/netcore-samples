using System;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Please input one of the commands below:");
            sb.AppendLine("1. p -> list all current processes.");
			sb.AppendLine("2. p{id} -> list specific process details. e.g.: p1234");
			sb.AppendLine("3. pt{id} -> list specific process threads. e.g.: pt1234");
            sb.AppendLine("4. q -> exit the programe.");

            string command = string.Empty;

            do
            {
                Console.WriteLine(sb.ToString());
                command = Console.ReadLine().ToLower();
                if(command == "p")
                {
                    foreach (var p in Process.GetProcesses())
                        Console.WriteLine(p.Id.ToString("0000000:") + p.ProcessName);
                }
				else if (command.StartsWith("pt"))
                {
                    int result;
                    if (int.TryParse(command.Substring(2), out result))
                    {
                        try
                        {
                            Process p = Process.GetProcessById(result);
                            if (p == null)
                                Console.WriteLine("Process " + command.TrimStart('p') + " not exist.");
                            else
                            {
                                Console.WriteLine("Threads for Process: " + p.ProcessName);
                                foreach (ProcessThread t in p.Threads)
                                    Console.WriteLine("-" + t.Id.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if(command.StartsWith("p"))
                {
                    int result;
                    if(int.TryParse(command.TrimStart('p'), out result))
                    {
                        try
                        {
                            Process p = Process.GetProcessById(result);
                            if (p == null)
                                Console.WriteLine("Process " + command.TrimStart('p') + " not exist.");
                            else
                            {
                                Console.WriteLine("Process: " + p.ProcessName);
                                Console.WriteLine("Id: " + command.TrimStart('p'));
                                Console.WriteLine("Priority: " + p.BasePriority);
                                Console.WriteLine("StartTime: " + p.StartTime);
                                Console.WriteLine("FileName: " + p.MainModule.FileName);
                                Console.WriteLine("UserName: " + p.StartInfo.UserName);
                                Console.WriteLine("WorkingDirectory: " + p.StartInfo.WorkingDirectory);

                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Process " + command.TrimStart('p') + " not exist.");
                    }
                }
                else
                {
                    
                }
            } while (command != "q");

            Console.WriteLine("byebye :)");
        }
    }
}

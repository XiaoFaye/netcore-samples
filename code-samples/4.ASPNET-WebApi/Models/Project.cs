using System;

namespace ConsoleApplication.Models
{
    public class Project
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		public decimal Progress { get; set; }
		public DateTime DueDate { get; set; }
    }
}
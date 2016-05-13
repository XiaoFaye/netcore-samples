using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConsoleApplication.Models;

namespace ConsoleApplication.Controllers
{
	[Route("/api/projects")]
    public class ProjectssController : Controller
    {
		private static List<Project> _projects = new List<Project>(new[] {
            new Project() { Id = 1, Name = "Computer", Version = "0.1", Progress = 0.30M, DueDate = DateTime.Now.AddDays(20) },
            new Project() { Id = 2, Name = "Radio", Version = "0.3", Progress = 0.60M, DueDate = DateTime.Now.AddDays(30) },
            new Project() { Id = 3, Name = "Apple", Version = "1.45", Progress = 0.35M, DueDate = DateTime.Now.AddDays(45) },
        });
		
		[HttpGet]
        public IEnumerable<Project> Get()
        {
            return _projects;
        }
		
		// GET api/values/5
		[HttpGet("{id}")]
        public Project Get(int id)
        {
            return _projects.Find(x=>x.Id == id);
        }

        // POST api/values
		[HttpPost]
        public void Post([FromBody]Project value)
        {
			_projects.Add(value);
        }

        // PUT api/values/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]Project value)
        {
			var result = _projects.Find(x=>x.Id == id);
			if(result != null)
			{
				result.Name = value.Name;
				result.Version = value.Version;
				result.Progress = value.Progress;
				result.DueDate = value.DueDate;
			}
        }

        // DELETE api/values/5
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
			_projects.Remove(_projects.Find(x=>x.Id == id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Lab1_Backend.Models; 

namespace Lab1_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Email = "alice@email.com" },
            new Student { Id = 2, Name = "Bob", Email = "bob@email.com" },
            new Student { Id = 3, Name = "Charlie", Email = "charlie@email.com" }
        };

        [HttpGet] //This method handles HTTP GET requests
        public IActionResult GetAllStudents()
        {
            return Ok(students);  //Return HTTP 200 OK response with the list of students in JSON format.
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(long id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }
    }
}
 
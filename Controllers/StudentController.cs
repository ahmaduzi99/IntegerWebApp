using Microsoft.AspNetCore.Mvc;
using IntegerWebApp.Models;
using System.Net;
using System.Xml.Linq;

namespace IntegerWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            var student = new List<Student>();
            student.Add(new Student()

            {
                Id = 1,
                Name = "ACHMAD FAUZI",
                Address = "CIANJUR",
                PhoneNumber = "1234567890"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "HELMI TRIS EDYAN",
                Address = "BANJAR",
                PhoneNumber = "234556789"
            });

            return View(student);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            Student stu = new Student()
            {
                StudentId = 102,
                Name = "mansi",
                Branch = "CSE",
                Gender ="f"
            };
            Address add = new Address()
            {
                StudentId = 102,
                City = "delhi",
                State = "Delhi",
                Country = "India",
                Pincode = "876569"
            };
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                student = stu,
                address = add,
                Title = "Student Details",
                Header = "Student Data"
            };
            return View(studentDetailsViewModel);
        }
    }
}

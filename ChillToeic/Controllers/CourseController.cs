using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using global::ChillToeic.Models;
namespace ChillToeic.Controllers
{
    


    
        public class CoursesController : Controller
        {
            public IActionResult Course()
            {
                List<Course> courses = GetCoursesFromDatabase();

                ViewData["Courses"] = courses;

                return View();
            }

            public IActionResult Details(int id)
            {
                Course course = GetCourseByIdFromDatabase(id);

                if (course == null)
                {
                    return NotFound();
                }

                ViewData["Course"] = course;

                return View();
            }

            private List<Course> GetCoursesFromDatabase()
            {
                var courses = new List<Course>
            {
                new Course { Id = 1, Name = "Course 1", Price = 100 },
                new Course { Id = 2, Name = "Course 2", Price = 150 },
                new Course { Id = 3, Name = "Course 3", Price = 200 }
            };

                return courses;
            }

            private Course GetCourseByIdFromDatabase(int id)
            {
                var courses = GetCoursesFromDatabase();

                foreach (var course in courses)
                {
                    if (course.Id == id)
                    {
                        return course;
                    }
                }

                return null;
            }
        }
    }


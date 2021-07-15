using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICoursesService _course;

        public CourseController(ICoursesService service)
        {
            _course = service;
        }

        public IActionResult Index()
        {
            CourseViewModel courseView = _course.GetCourses();
            return View(courseView);
        }
    }
}

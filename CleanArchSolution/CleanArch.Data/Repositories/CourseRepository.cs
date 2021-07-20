using CleanArch.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private CleanArchDbContext _contxt;
        public CourseRepository(CleanArchDbContext cleanArchDbContext)
        {
            _contxt = cleanArchDbContext;
        }

        public void Add(Course course)
        {
            _contxt.Courses.Add(course);
            _contxt.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _contxt.Courses;
        }
    }
}

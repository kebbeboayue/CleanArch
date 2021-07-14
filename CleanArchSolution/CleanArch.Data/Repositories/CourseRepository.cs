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

        public IEnumerable<Course> GetCourses()
        {
            return _contxt.Courses;
        }
    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICoursesService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = mediatorHandler;
            _autoMapper = mapper;
        }

        public void CreateCourse(CourseViewModel courseView)
        {

            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseView));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}

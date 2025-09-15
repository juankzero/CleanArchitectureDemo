
using CleanArchitectureDemo.Application.DTOs;
using MediatR;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Commands
{
    public class CreateCourseCommand : IRequest<Course>
    {
        public CourseDto Course { get; set; }
    }
}

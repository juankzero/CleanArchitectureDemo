
using CleanArchitectureDemo.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.Queries
{
    public class GetAllCoursesQuery : IRequest<IEnumerable<Course>>
    {
    }
}

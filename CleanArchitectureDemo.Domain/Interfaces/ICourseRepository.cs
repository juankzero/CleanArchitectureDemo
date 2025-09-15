
using CleanArchitectureDemo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);
        Task AddAsync(Course course);
        Task UpdateAsync(Course course);
        Task DeleteAsync(int id);
    }
}

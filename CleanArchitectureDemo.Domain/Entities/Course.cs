
namespace CleanArchitectureDemo.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationHours { get; set; }
        public string Instructor { get; set; }
    }
}

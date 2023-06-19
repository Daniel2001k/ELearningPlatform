using ELearningPlatform.Server.Data.Models;

namespace ELearningPlatform.Server.Services;

public interface ICourseService
{
    Task<Course> AddCourseAsync(Course course);
    Task<IEnumerable<Course>> GetListAsync();
}

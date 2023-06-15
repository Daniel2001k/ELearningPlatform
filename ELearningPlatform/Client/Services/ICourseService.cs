using ELearningPlatform.Shared;

namespace ELearningPlatform.Client.Services;

public interface ICourseService
{
    Task AddCourse(Course course);
    Task DeleteCourse(int id);
    Task<List<Course>> GetCourseList();
}

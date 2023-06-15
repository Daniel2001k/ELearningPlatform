using ELearningPlatform.Client.Services.Http;
using ELearningPlatform.Shared;
using static MudBlazor.CategoryTypes;

namespace ELearningPlatform.Client.Services;

public class CourseService : ICourseService
{
    private readonly IHttpService _httpService;

    public CourseService(IHttpService httpService) => _httpService = httpService;
    public async Task AddCourse(Course course)
    {
        await _httpService.Post($"api/course/Insert", course);
    }

    public Task DeleteCourse(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Course>> GetCourseList()
    {
        var courses = await _httpService.Get<List<Course>>($"api/course/GetList");
        return courses;
    }
}

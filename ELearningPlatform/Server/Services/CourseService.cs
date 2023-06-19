using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningPlatform.Server.Services;

public class CourseService : ICourseService
{
    private readonly CoursePlatformContext _dbContext;

    public CourseService(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Course> AddCourseAsync(Course course)
    {
        await _dbContext.Courses.AddAsync(course);
        await _dbContext.SaveChangesAsync();

        return course;
    }

    public async Task<IEnumerable<Course>> GetListAsync()
    {

        var result = await _dbContext.Courses.Include(x => x.Language)
                                             .Include(x => x.Level)
                                             .Include(x => x.Tutor)
                                                .ThenInclude(x => x.User)
                                             .ToListAsync();

        return result;
    }
}
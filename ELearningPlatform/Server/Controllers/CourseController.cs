using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Course = ELearningPlatform.Shared.Course;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/course/[action]")]
[ApiController]
public class CourseController : Controller
{
    private readonly CoursePlatformContext _dbContext;
    public CourseController(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> GetList()
    {
        try
        {
            var result = await _dbContext.Courses.Include(x => x.Language)
                                                 .Include(x => x.Level)
                                                 .Include(x => x.Tutor)
                                                    .ThenInclude(x => x.User)
                                                 .ToListAsync();

            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost]
    public async Task Insert([FromBody] Course course)
    {
        try
        {
            var courseDomain = new Data.Models.Course(1, course.Language.Id, course.Level.Id, course.Price);

            await _dbContext.Courses.AddAsync(courseDomain);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            BadRequest(ex);
        }
    }
}

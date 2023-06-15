using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurseLevel = ELearningPlatform.Shared.CurseLevel;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/level/[action]")]
[ApiController]
public class LevelController : Controller
{
    private readonly CoursePlatformContext _dbContext;
    public LevelController(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CurseLevel>>> GetList()
    {
        try
        {
            var result = await _dbContext.CurseLevels.ToListAsync();
            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}

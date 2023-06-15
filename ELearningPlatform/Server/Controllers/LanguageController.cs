using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Language = ELearningPlatform.Shared.Language;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/language/[action]")]
[ApiController]
public class LanguageController : Controller
{
    private readonly CoursePlatformContext _dbContext;
    public LanguageController(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Language>>> GetList()
    {
        try
        {
            var result = await _dbContext.Languages.ToListAsync();
            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
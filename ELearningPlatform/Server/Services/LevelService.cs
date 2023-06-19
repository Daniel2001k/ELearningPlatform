using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningPlatform.Server.Services;

public class LevelService : ILevelService
{
    private readonly CoursePlatformContext _dbContext;

    public LevelService(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<CurseLevel>> GetListAsync()
    {
        var result = await _dbContext.CurseLevels.ToListAsync();

        return result;
    }
}

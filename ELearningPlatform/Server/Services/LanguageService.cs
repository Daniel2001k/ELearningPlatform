using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningPlatform.Server.Services;

public class LanguageService : ILanguageService
{
    private readonly CoursePlatformContext _dbContext;

    public LanguageService(CoursePlatformContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Language>> GetListAsync()
    {
        var result = await _dbContext.Languages.ToListAsync();

        return result;
    }
}

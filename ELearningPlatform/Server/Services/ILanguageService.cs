using ELearningPlatform.Server.Data.Models;

namespace ELearningPlatform.Server.Services;

public interface ILanguageService
{
    Task<IEnumerable<Language>> GetListAsync();
}

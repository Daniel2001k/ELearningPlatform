using ELearningPlatform.Shared;

namespace ELearningPlatform.Client.Services;

public interface ILanguageService
{
    Task<List<Language>> GetLanguageList();
}

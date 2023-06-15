using ELearningPlatform.Client.Services.Http;
using ELearningPlatform.Shared;

namespace ELearningPlatform.Client.Services;

public class LanguageService : ILanguageService
{
    private readonly IHttpService _httpService;

    public LanguageService(IHttpService httpService) => _httpService = httpService;
    public async Task<List<Language>> GetLanguageList()
    {
        var courses = await _httpService.Get<List<Language>>($"api/language/GetList");
        return courses;
    }
}

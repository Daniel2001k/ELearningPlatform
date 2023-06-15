using ELearningPlatform.Client.Services.Http;
using ELearningPlatform.Shared;

namespace ELearningPlatform.Client.Services;

public class LevelService : ILevelService
{
    private readonly IHttpService _httpService;

    public LevelService(IHttpService httpService) => _httpService = httpService;
    public async Task<List<CurseLevel>> GetLevelList()
    {
        var levels = await _httpService.Get<List<CurseLevel>>($"api/level/GetList");
        return levels;
    }
}

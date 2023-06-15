using ELearningPlatform.Shared;

namespace ELearningPlatform.Client.Services;

public interface ILevelService
{
    Task<List<CurseLevel>> GetLevelList();
}

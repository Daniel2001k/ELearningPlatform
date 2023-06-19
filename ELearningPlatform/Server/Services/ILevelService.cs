using ELearningPlatform.Server.Data.Models;

namespace ELearningPlatform.Server.Services;

public interface ILevelService
{
    Task<IEnumerable<CurseLevel>> GetListAsync();
}

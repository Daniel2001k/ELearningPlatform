using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data.Models;
using ELearningPlatform.Server.Services;
using MediatR;

namespace ELearningPlatform.Server.Handlers;

public class GetLevelListHandler : IRequestHandler<GetLevelListCommand, IEnumerable<CurseLevel>>
{
    private readonly ILevelService _levelService;
    private readonly ILogger<GetLevelListHandler> _logger;

    public GetLevelListHandler(ILevelService levelService, ILogger<GetLevelListHandler> logger)
    {
        _levelService = levelService;
        _logger = logger;
    }

    public async Task<IEnumerable<CurseLevel>> Handle(GetLevelListCommand request, CancellationToken cancellationToken)
    {
        try
        {
            return await _levelService.GetListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to create course for {request}");
            throw;
        }
    }
}

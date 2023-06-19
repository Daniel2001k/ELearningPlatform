using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data.Models;
using ELearningPlatform.Server.Services;
using MediatR;

namespace ELearningPlatform.Server.Handlers;

public class GetLanguageListHandler : IRequestHandler<GetLanguageListCommand, IEnumerable<Language>>
{
    private readonly ILanguageService _languageService;
    private readonly ILogger<GetLanguageListHandler> _logger;

    public GetLanguageListHandler(ILanguageService languageService, ILogger<GetLanguageListHandler> logger)
    {
        _languageService = languageService;
        _logger = logger;
    }

    public async Task<IEnumerable<Language>> Handle(GetLanguageListCommand request, CancellationToken cancellationToken)
    {
        try
        {
            return await _languageService.GetListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to create course for {request}");
            throw;
        }
    }
}

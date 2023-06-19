using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data.Models;
using ELearningPlatform.Server.Services;
using MediatR;

namespace ELearningPlatform.Server.Handlers;

public class GetCourseListHandler : IRequestHandler<GetCourseListCommand, IEnumerable<Course>>
{
    private readonly ICourseService _courseService;
    private readonly ILogger<GetCourseListHandler> _logger;

    public GetCourseListHandler(ICourseService courseService, ILogger<GetCourseListHandler> logger)
    {
        _courseService = courseService;
        _logger = logger;
    }

    public async Task<IEnumerable<Course>> Handle(GetCourseListCommand request, CancellationToken cancellationToken)
    {
        try
        {
            return await _courseService.GetListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to create course for {request}");
            throw;
        }
    }
}

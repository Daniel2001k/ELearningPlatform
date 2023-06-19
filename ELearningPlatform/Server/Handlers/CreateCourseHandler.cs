using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data.Models;
using ELearningPlatform.Server.Services;
using MediatR;

namespace ELearningPlatform.Server.Handlers;

public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, Course>
{
    private readonly ICourseService _courseService;
    private readonly ILogger<CreateCourseHandler> _logger;

    public CreateCourseHandler(ICourseService courseService, ILogger<CreateCourseHandler> logger)
    {
        _courseService = courseService;
        _logger = logger;
    }

    public async Task<Course> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        try
        {
            return await _courseService.AddCourseAsync(request.Course);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to create course for {request}");
            throw;
        }
    }
}

using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Course = ELearningPlatform.Shared.Course;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/course/[action]")]
[ApiController]
public class CourseController : Controller
{
    private readonly IMediator _mediator;

    public CourseController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> GetList()
    {
        try
        {
            var command = new GetCourseListCommand();
            var result = await _mediator.Send(command);

            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost]
    public async Task Insert([FromBody] Course course)
    {
        try
        {
            var command = new CreateCourseCommand(course.ToDomain());
            var result = await _mediator.Send(command);

            Ok();
        }
        catch (Exception ex)
        {
            BadRequest(ex);
        }
    }
}

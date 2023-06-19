using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurseLevel = ELearningPlatform.Shared.CurseLevel;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/level/[action]")]
[ApiController]
public class LevelController : Controller
{
    private readonly IMediator _mediator;

    public LevelController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CurseLevel>>> GetList()
    {
        try
        {
            var command = new GetLevelListCommand();
            var result = await _mediator.Send(command);
            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}

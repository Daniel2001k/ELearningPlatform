using ELearningPlatform.Server.Commands;
using ELearningPlatform.Server.Data;
using ELearningPlatform.Server.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Language = ELearningPlatform.Shared.Language;

namespace ELearningPlatform.Server.Controllers;

[Route($"api/language/[action]")]
[ApiController]
public class LanguageController : Controller
{
    private readonly IMediator _mediator;

    public LanguageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Language>>> GetList()
    {
        try
        {
            var command = new GetLanguageListCommand();
            var result = await _mediator.Send(command);

            return Ok(result.ToUI());
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
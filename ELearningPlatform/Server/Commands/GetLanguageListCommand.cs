using ELearningPlatform.Server.Data.Models;
using MediatR;

namespace ELearningPlatform.Server.Commands;

public class GetLanguageListCommand : IRequest<IEnumerable<Language>>
{
}

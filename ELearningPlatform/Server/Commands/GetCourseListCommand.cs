using ELearningPlatform.Server.Data.Models;
using MediatR;

namespace ELearningPlatform.Server.Commands;

public class GetCourseListCommand : IRequest<IEnumerable<Course>>
{
}

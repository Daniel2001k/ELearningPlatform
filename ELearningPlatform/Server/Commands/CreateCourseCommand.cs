using ELearningPlatform.Server.Data.Models;
using MediatR;

namespace ELearningPlatform.Server.Commands;

public class CreateCourseCommand : IRequest<Course>
{
    public CreateCourseCommand(Course course)
    {
        Course = course;
    }

    public Course Course { get; set; }
}

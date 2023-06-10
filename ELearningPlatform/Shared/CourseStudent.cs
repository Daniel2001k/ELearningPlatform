namespace ELearningPlatform.Shared;

public class CourseStudent
{
    public CourseStudent(int id, User student, Course course)
    {
        Id = id;
        Student = student;
        Course = course;
    }

    public int Id { get; set; }
    public User Student { get; set; }
    public Course Course { get; set; }
}
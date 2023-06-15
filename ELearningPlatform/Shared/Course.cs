namespace ELearningPlatform.Shared;

public class Course
{
    public Course()
    {

    }
    public Course(int id, int rating, double price, Language language, CurseLevel level, Tutor tutor, List<CourseStudent> courseStudents)
    {
        Id = id;
        Rating = rating;
        Price = price;
        Language = language;
        Level = level;
        Tutor = tutor;
        CourseStudents = courseStudents;
    }

    public int Id { get; set; }
    public int Rating { get; set; }
    public double? Price { get; set; }
    public Language Language { get; set; }
    public CurseLevel Level { get; set; }
    public Tutor Tutor { get; set; }
    public List<CourseStudent> CourseStudents { get; set; }
}

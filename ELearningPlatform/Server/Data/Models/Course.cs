namespace ELearningPlatform.Server.Data.Models;

public partial class Course
{
    public Course(int tutorId, int languageId, int levelId, double? price)
    {
        TutorId = tutorId;
        LanguageId = languageId;
        LevelId = levelId;
        Price = price;
    }

    public int Id { get; set; }
    public int TutorId { get; set; }
    public int LanguageId { get; set; }
    public int LevelId { get; set; }
    public double? Price { get; set; }

    public virtual Language Language { get; set; } = null!;
    public virtual CurseLevel Level { get; set; } = null!;
    public virtual Tutor Tutor { get; set; } = null!;
    public virtual ICollection<CourseStudent> CourseStudents { get; set; }
}

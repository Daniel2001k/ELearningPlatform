namespace ELearningPlatform.Server.Data.Models;

public partial class Tutor
{
    public Tutor()
    {
        Courses = new HashSet<Course>();
    }

    public Tutor(int userId)
    {
        UserId = userId;
    }

    public int Id { get; set; }
    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
    public virtual ICollection<Course> Courses { get; set; }
}

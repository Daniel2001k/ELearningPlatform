namespace ELearningPlatform.Server.Data.Models;

public partial class Language
{
    public Language()
    {
        Courses = new HashSet<Course>();
    }

    public Language(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; }
}

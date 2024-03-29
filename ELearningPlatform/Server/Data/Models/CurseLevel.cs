﻿namespace ELearningPlatform.Server.Data.Models;

public partial class CurseLevel
{
    public CurseLevel()
    {
        Courses = new HashSet<Course>();
    }

    public CurseLevel(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; }
}

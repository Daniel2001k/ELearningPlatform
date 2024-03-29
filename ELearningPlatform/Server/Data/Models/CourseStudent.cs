﻿namespace ELearningPlatform.Server.Data.Models;

public partial class CourseStudent
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int Student { get; set; }

    public virtual Course Course { get; set; } = null!;
}

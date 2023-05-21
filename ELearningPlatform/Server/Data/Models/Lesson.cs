using System;
using System.Collections.Generic;

namespace ELearningPlatform.Server.Data.Models
{
    public partial class Lesson
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TaskId { get; set; }
        public int Order { get; set; }
        public DateTime Time { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Task Task { get; set; } = null!;
    }
}

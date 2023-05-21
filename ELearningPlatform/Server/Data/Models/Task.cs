using System;
using System.Collections.Generic;

namespace ELearningPlatform.Server.Data.Models
{
    public partial class Task
    {
        public Task()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public int TaskTypeId { get; set; }

        public virtual TaskType TaskType { get; set; } = null!;
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

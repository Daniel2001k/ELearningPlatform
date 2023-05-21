using System;
using System.Collections.Generic;

namespace ELearningPlatform.Server
{
    public partial class Task
    {
        public int Id { get; set; }
        public int TaskTypeId { get; set; }

        public virtual TaskType TaskType { get; set; } = null!;
    }
}

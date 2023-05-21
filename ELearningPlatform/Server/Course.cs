﻿using System;
using System.Collections.Generic;

namespace ELearningPlatform.Server
{
    public partial class Course
    {
        public Course()
        {
            CourseStudents = new HashSet<CourseStudent>();
        }

        public int Id { get; set; }
        public int TutorId { get; set; }
        public int LanguageId { get; set; }
        public int LevelId { get; set; }

        public virtual Language Language { get; set; } = null!;
        public virtual CurseLevel Level { get; set; } = null!;
        public virtual Tutor Tutor { get; set; } = null!;
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
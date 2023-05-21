using System;
using System.Collections.Generic;

namespace ELearningPlatform.Server.Data.Models
{
    public partial class User
    {
        public User()
        {
            Students = new HashSet<Student>();
            Tutors = new HashSet<Tutor>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
        public string Pesel { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}

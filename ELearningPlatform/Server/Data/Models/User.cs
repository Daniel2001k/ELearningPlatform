﻿namespace ELearningPlatform.Server.Data.Models;

public partial class User
{
    public User()
    {
        Students = new HashSet<Student>();
        Tutors = new HashSet<Tutor>();
    }

    public User(string name, string surname, DateTime birthDate, string pesel)
    {
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
        Pesel = pesel;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string Pesel { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<Tutor> Tutors { get; set; }
}

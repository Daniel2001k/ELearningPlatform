namespace ELearningPlatform.Shared;

public class User
{
    public User(int id, string name, string surname, DateTime birthDate, string pesel)
    {
        Id = id;
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
        Pesel = pesel;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Pesel { get; set; }
}

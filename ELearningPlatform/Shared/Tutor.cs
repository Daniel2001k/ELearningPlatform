namespace ELearningPlatform.Shared;

public class Tutor
{
    public Tutor(int id, User user)
    {
        Id = id;
        User = user;
    }

    public int Id { get; set; }

    public User User { get; set; }
}

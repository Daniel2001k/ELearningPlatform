namespace ELearningPlatform.Shared;

public class CurseLevel
{
    public CurseLevel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}

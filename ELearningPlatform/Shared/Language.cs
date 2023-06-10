namespace ELearningPlatform.Shared;

public class Language
{
    public Language(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}

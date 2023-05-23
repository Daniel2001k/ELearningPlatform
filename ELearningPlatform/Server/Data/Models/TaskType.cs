namespace ELearningPlatform.Server.Data.Models;

public partial class TaskType
{
    public TaskType()
    {
        Tasks = new HashSet<Task>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; }
}

namespace ELearningPlatform.Server.Data.Models;

public partial class Task
{
    public int Id { get; set; }
    public int TaskTypeId { get; set; }

    public virtual TaskType TaskType { get; set; } = null!;
}

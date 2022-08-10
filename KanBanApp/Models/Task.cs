namespace KanBanApp.Models;

public class Task
{
    public string title { get; set; }
    public string description { get; set; }
    public string status { get; set; }
    public Subtask[] subtasks { get; set; }
}
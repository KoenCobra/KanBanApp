using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store.Actions.Load;

public class LoadTaskAction
{
    public LoadTaskAction(Task? task)
    {
        Task = task;
    }

    public Task? Task { get; }
}
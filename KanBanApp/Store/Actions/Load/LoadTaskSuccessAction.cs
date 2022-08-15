using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store.Actions.Load;

public class LoadTaskSuccessAction
{
    public LoadTaskSuccessAction(Task? task)
    {
        Task = task;
    }

    public Task? Task { get; }
}
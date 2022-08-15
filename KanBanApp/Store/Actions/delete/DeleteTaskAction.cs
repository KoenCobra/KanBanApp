using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store.Actions.delete;

public class DeleteTaskAction
{
    public DeleteTaskAction(Task? task)
    {
        Task = task;
    }

    public Task? Task { get; set; }
}
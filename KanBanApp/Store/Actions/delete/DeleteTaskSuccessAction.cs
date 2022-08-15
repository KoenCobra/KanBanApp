using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store.Actions.Delete;

public class DeleteTaskSuccessAction
{
    public DeleteTaskSuccessAction(Task? task)
    {
        Task = task;
    }

    public Task? Task { get; set; }
}
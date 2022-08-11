using KanbanApp.Models;

namespace KanBanApp.Store.Actions.Delete;

public class DeleteKanBanSuccessAction
{
    public DeleteKanBanSuccessAction(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
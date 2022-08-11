using KanbanApp.Models;

namespace KanBanApp.Store.Actions.Delete;

public class DeleteKanBanAction
{
    public DeleteKanBanAction(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
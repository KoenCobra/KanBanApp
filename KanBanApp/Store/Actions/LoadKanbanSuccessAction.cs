using KanBanApp.Models;

namespace KanBanApp.Store.Actions;

public class LoadKanbanSuccessAction
{
    public LoadKanbanSuccessAction(KanbanRootObject kanbanRootObject)
    {
        KanbanRootObject = kanbanRootObject;
    }

    public KanbanRootObject KanbanRootObject { get; }
}
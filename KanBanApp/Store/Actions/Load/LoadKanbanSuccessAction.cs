using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Load;

public class LoadKanbanSuccessAction
{
    public LoadKanbanSuccessAction(KanBanObject? boards)
    {
        Boards = boards;
    }

    public KanBanObject? Boards { get; }
}
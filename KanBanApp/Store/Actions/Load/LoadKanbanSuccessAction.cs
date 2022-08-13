using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Load;

public class LoadKanbanSuccessAction
{
    public LoadKanbanSuccessAction(List<Board>? boards)
    {
        Boards = boards;
    }

    public List<Board>? Boards { get; }
}
using KanBanApp.Models;

namespace KanBanApp.Store;

public class KanbanState
{
    public KanbanState(List<Board>? boards)
    {
        Boards = boards;
    }

    public List<Board>? Boards { get; }
}
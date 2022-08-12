using KanBanApp.Models;

namespace KanBanApp.Store;

public class KanbanState
{
    public KanbanState(KanBanObject? boards)
    {
        Boards = boards;
    }

    public KanBanObject? Boards { get; }
}
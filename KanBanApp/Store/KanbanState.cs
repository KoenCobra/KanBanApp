using KanBanApp.Models;

namespace KanBanApp.Store;

public class KanbanState
{
    public KanbanState(KanBanObject? boards, Board? board)
    {
        Boards = boards;
        Board = board;
    }

    public KanBanObject? Boards { get; }
    public Board? Board { get; }
}
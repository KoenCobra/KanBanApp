using KanbanApp.Models;

namespace KanBanApp.Store.State;

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
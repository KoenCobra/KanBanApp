using KanBanApp.Models;

namespace KanBanApp.Store;

public class KanbanState
{
    public KanbanState(List<Board>? boards, Board? board)
    {
        Boards = boards;
        Board = board;
    }

    public List<Board>? Boards { get; }
    public Board? Board { get; }
}
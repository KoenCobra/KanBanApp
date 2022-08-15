using KanBanApp.Models;
using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store;

public class KanbanState
{
    public KanbanState(List<Board>? boards, Board? board, Task? task)
    {
        Boards = boards;
        Board = board;
        Task = task;
    }

    public List<Board>? Boards { get; }
    public Task? Task { get; set; }
    public Board? Board { get; }
}
using KanBanApp.Models;

namespace KanBanApp.Store.State;

public class KanbanState
{
    public KanbanState(KanbanRootObject? kanbanRootObject, Board? board)
    {
        KanbanRootObject = kanbanRootObject;
        Board = board;
    }

    public KanbanRootObject? KanbanRootObject { get; }
    public Board? Board { get; }
}
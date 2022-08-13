using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Create;

public class CreateBoardAction
{
    public CreateBoardAction(Board? board)
    {
        Board = board;
    }

    public Board? Board { get; }
}
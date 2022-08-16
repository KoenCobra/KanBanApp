using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Update;

public class UpdateBoardAction
{
    public UpdateBoardAction(Board? board)
    {
        Board = board;
    }

    public Board? Board { get; }
}
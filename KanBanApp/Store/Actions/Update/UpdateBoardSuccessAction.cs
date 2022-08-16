using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Update;

public class UpdateBoardSuccessAction
{
    public UpdateBoardSuccessAction(Board? board)
    {
        Board = board;
    }

    public Board? Board { get; }
}
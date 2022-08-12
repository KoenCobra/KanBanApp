using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Create
{
    public class CreateBoardSuccessAction
    {
        public CreateBoardSuccessAction(Board? board)
        {
            Board = board;
        }

        public Board? Board { get; }
    }
}

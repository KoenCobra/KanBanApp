using KanBanApp.Models;

namespace KanBanApp.Store.Actions.Update
{
    public class UpdateBoardAction
    {
        public UpdateBoardAction(string? name, Board? board)
        {
            Name = name;
            Board = board;
        }

        public string? Name { get;}
        public Board? Board { get;}
    }
}

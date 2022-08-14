using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Update;

namespace KanBanApp.Store.Reducers
{
    public class UpdateBoardActionReducer
    {
        [ReducerMethod]
        public static KanbanState ReduceUpdateBoardAction(KanbanState state, UpdateBoardAction action)
        {
            return new KanbanState(state.Boards, state.Board);
        }

        [ReducerMethod]
        public static KanbanState ReduceUpdateBoardSuccessAction(KanbanState state, UpdateBoardSuccessAction action)
        {
            if (state.Boards is null)
            {
                return new KanbanState(new List<Board>(), state.Board);
            }

            var updatedList = state.Boards
                .Where(t => t.name != action.Board.name)
                .ToList();

            updatedList.Add(action.Board);
            updatedList = updatedList.ToList();

            return new KanbanState(updatedList, state.Board);
        }
    }
}

using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;

namespace KanBanApp.Store.Reducers
{
    public class CreateBoardActionReducer
    {
        [ReducerMethod]
        public static KanbanState ReduceCreateBoardAction(KanbanState state, CreateBoardAction _) =>
            new KanbanState(state.Boards, state.Board);

        [ReducerMethod]
        public static KanbanState ReduceCreateBoardSuccessAction(KanbanState state, CreateBoardSuccessAction action)
        {
            KanBanObject currentBoards = state.Boards;

            currentBoards.boards.Append(action.Board);

            return new KanbanState(currentBoards, state.Board);
        }
    }
}

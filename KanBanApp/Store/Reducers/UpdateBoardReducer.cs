using Fluxor;
using KanBanApp.Store.Actions.Update;

namespace KanBanApp.Store.Reducers;

public class UpdateBoardReducer
{
    [ReducerMethod]
    public static KanbanState ReduceUpdateBoardAction(KanbanState state, UpdateBoardAction action)
    {
        return new KanbanState(state.Boards, state.Board, state.Task);
    }

    [ReducerMethod]
    public static KanbanState ReduceUpdateBoardSuccessAction(KanbanState state, UpdateBoardSuccessAction action)
    {
        return new KanbanState(state.Boards, action.Board, state.Task);
    }
}
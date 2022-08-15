using Fluxor;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Reducers;

public class LoadTaskReducer
{
    [ReducerMethod]
    public static KanbanState ReduceLoadTaskAction(KanbanState state, LoadTaskAction _)
    {
        return new KanbanState(state.Boards, state.Board, state.Task);
    }

    [ReducerMethod]
    public static KanbanState ReduceLoadTaskSuccessAction(KanbanState state, LoadTaskSuccessAction action)
    {
        return new KanbanState(state.Boards, state.Board, action.Task);
    }
}
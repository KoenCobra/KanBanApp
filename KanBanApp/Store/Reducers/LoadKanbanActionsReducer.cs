using Fluxor;
using KanBanApp.Store.Actions.Load;
using KanBanApp.Store.State;

namespace KanBanApp.Store.Reducers;

public static class LoadKanbanActionsReducer
{
    [ReducerMethod]
    public static KanbanState ReduceLoadTodosAction(KanbanState state, LoadKanbanAction _)
    {
        return new KanbanState(null, state.Board);
    }

    [ReducerMethod]
    public static KanbanState ReduceLoadTodosSuccessAction(KanbanState state, LoadKanbanSuccessAction action)
    {
        return new KanbanState(action.Boards, state.Board);
    }
}
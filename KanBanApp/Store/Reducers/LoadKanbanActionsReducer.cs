using Fluxor;
using KanBanApp.Store.Actions;
using KanBanApp.Store.State;

namespace KanBanApp.Store.Reducers;

public static class LoadKanbanActionsReducer
{
    [ReducerMethod]
    public static KanbanState ReduceLoadTodosAction(KanbanState state, LoadKanbanAction _)
    {
        return new(null, state.Board);
    }

    [ReducerMethod]
    public static KanbanState ReduceLoadTodosSuccessAction(KanbanState state, LoadKanbanSuccessAction action)
    {
        return new KanbanState(action.KanbanRootObject, state.Board);
    }
}
using Fluxor;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Reducers;

public static class LoadKanbanActionsReducer
{
    [ReducerMethod]
    public static KanbanState ReduceLoadBoardAction(KanbanState state, LoadKanbanAction _)
    {
        return new KanbanState(null, null);
    }

    [ReducerMethod]
    public static KanbanState ReduceLoadBoardSuccessAction(KanbanState state, LoadKanbanSuccessAction action)
    {
        return new KanbanState(action.Boards, state.Board);
    }
}
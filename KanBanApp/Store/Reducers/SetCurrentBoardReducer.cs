using Fluxor;
using KanBanApp.Store.Actions.SetCurrentBoard;

namespace KanBanApp.Store.Reducers;

public class SetCurrentBoardReducer
{
    [ReducerMethod]
    public static KanbanState ReduceSetCurrentBoardAction(KanbanState state, SetCurrentBoardAction action)
    {
        return new KanbanState(state.Boards, state.Board);
    }

    [ReducerMethod]
    public static KanbanState ReduceSetCurrentBoardSuccessAction(KanbanState state, SetCurrentBoardSuccessAction action)
    {
        if (state.Boards is null) return new KanbanState(null, null);

        var setCurrentBoard = state.Boards.Find(b => b.name == action.Name);

        return new KanbanState(state.Boards, setCurrentBoard);
    }
}
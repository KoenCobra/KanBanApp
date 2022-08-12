using Fluxor;
using KanBanApp.Store.Actions.Delete;

namespace KanBanApp.Store.Reducers;

public class DeleteKanBanActionReducer
{
    [ReducerMethod]
    public static KanbanState ReduceDeleteKanbBanAction(KanbanState state, DeleteKanBanAction _)
    {
        return new KanbanState(state.Boards, state.Board);
    }

    [ReducerMethod]
    public static KanbanState ReduceDeleteKanbBanSuccessAction(KanbanState state, DeleteKanBanSuccessAction action)
    {
        if (state.Boards is null)
        {
            return new KanbanState(null, state.Board);
        }


        return new KanbanState(state.Boards, state.Board);
    }
}
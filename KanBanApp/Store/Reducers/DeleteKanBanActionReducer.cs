using Fluxor;
using KanBanApp.Store.Actions.Delete;
using KanBanApp.Store.State;

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

        var updatedKanbBans = state.Boards.boards.Where(t => t.name != action.Name);

        return new KanbanState(state.Boards, state.Board);
    }
}
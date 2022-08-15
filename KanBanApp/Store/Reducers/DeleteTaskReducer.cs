using Fluxor;
using KanBanApp.Store.Actions.delete;

namespace KanBanApp.Store.Reducers;

public class DeleteTaskReducer
{
    [ReducerMethod]
    public static KanbanState ReduceDeleteTaskAction(KanbanState state, DeleteTaskAction action)
    {
        return new KanbanState(state.Boards, state.Board, state.Task);
    }

    [ReducerMethod]
    public static KanbanState ReduceDeleteTaskSuccessAction(KanbanState state, DeleteTaskSuccessAction action)
    {
        var currentBoard = state.Board;
        currentBoard.columns.Select(c => c.tasks.Remove(action.Task)).Distinct().ToList();

        return new KanbanState(state.Boards, currentBoard, null);
    }
}
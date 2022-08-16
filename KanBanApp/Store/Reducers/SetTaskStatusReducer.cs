using Fluxor;
using KanBanApp.Store.Actions.SetTaskStatus;

namespace KanBanApp.Store.Reducers;

public class SetTaskStatusReducer
{
    [ReducerMethod]
    public static KanbanState ReduceSetTaskStatusAction(KanbanState state, SetTaskStatusAction action)
    {
        return new KanbanState(state.Boards, state.Board, state.Task);
    }

    [ReducerMethod]
    public static KanbanState ReduceSetTaskStatusSuccessAction(KanbanState state, SetTaskStatusSuccessAction action)
    {
        var currentTask = state.Task;
        currentTask.status = action.Status;
        foreach (var column in state.Board.columns.Where(c => c.name == action.Status))
            column.tasks.Add(currentTask);

        foreach (var column in state.Board.columns.Where(c => c.name != action.Status))
            column.tasks.Remove(currentTask);


        return new KanbanState(state.Boards, state.Board, currentTask);
    }
}
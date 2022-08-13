using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;

namespace KanBanApp.Store.Reducers;

public class CreateBoardActionReducer
{
    [ReducerMethod]
    public static KanbanState ReduceCreateBoardAction(KanbanState state, CreateBoardAction action)
    {
        return new KanbanState(state.Boards);
    }

    [ReducerMethod]
    public static KanbanState ReduceCreateBoardSuccessAction(KanbanState state, CreateBoardSuccessAction action)
    {
        var boards = state.Boards is null ? new List<Board>() : state.Boards;

        if (action.Board != null) boards.Add(action.Board);

        return new KanbanState(boards);
    }
}
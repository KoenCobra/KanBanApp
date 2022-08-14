﻿using Fluxor;
using KanBanApp.Store.Actions.delete;

namespace KanBanApp.Store.Reducers;

public class DeleteBoardReducer
{
    [ReducerMethod]
    public static KanbanState ReduceDeleteBoardAction(KanbanState state, DeleteBoardAction action)
    {
        return new KanbanState(state.Boards, state.Board);
    }

    [ReducerMethod]
    public static KanbanState ReduceDeleteBoardSuccessAction(KanbanState state, DeleteBoardSuccessAction action)
    {
        if (state.Boards is null) return new KanbanState(null, state.Board);

        var currentState = state.Boards;
        currentState.Remove(state.Board);

        return new KanbanState(currentState, null);
    }
}
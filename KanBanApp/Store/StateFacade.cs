using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Delete;
using KanBanApp.Store.Actions.Load;
using KanBanApp.Store.Actions.SetCurrentBoard;
using KanBanApp.Store.Actions.SetTaskStatus;
using KanBanApp.Store.Actions.Update;
using Task = KanBanApp.Models.Task;

namespace KanBanApp.Store;

public class StateFacade
{
    private readonly IDispatcher _dispatcher;

    public StateFacade(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    public void LoadKanBan()
    {
        _dispatcher.Dispatch(new LoadKanbanAction());
    }

    public void SetCurrentBoard(string? name)
    {
        _dispatcher.Dispatch(new SetCurrentBoardAction(name));
    }

    public void UpdateBoard(Board? board)
    {
        _dispatcher.Dispatch(new UpdateBoardAction(board));
    }

    public void DeleteBoard(string? name)
    {
        _dispatcher.Dispatch(new DeleteBoardAction(name));
    }

    public void LoadTask(Task? task)
    {
        _dispatcher.Dispatch(new LoadTaskAction(task));
    }

    public void DeleteTask(Task? task)
    {
        _dispatcher.Dispatch(new DeleteTaskAction(task));
    }

    public void UpdateTaskStatus(string status)
    {
        _dispatcher.Dispatch(new SetTaskStatusAction(status));
    }
}
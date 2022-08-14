using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;
using KanBanApp.Store.Actions.delete;
using KanBanApp.Store.Actions.Load;
using KanBanApp.Store.Actions.SetCurrentBoard;
using KanBanApp.Store.Actions.Update;

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

    public void CreateBoard(Board? board)
    {
        _dispatcher.Dispatch(new CreateBoardAction(board));
    }

    public void UpdateBoard(string name, Board? board)
    {
        _dispatcher.Dispatch(new UpdateBoardAction(name, board));
    }

    public void DeleteBoard(string? name)
    {
        _dispatcher.Dispatch(new DeleteBoardAction(name));
    }
}
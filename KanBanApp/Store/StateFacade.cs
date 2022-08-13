using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;
using KanBanApp.Store.Actions.delete;
using KanBanApp.Store.Actions.Load;

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

    public void CreateBoard(Board? board)
    {
        _dispatcher.Dispatch(new CreateBoardAction(board));
    }

    public void DeleteBoard(string? name)
    {
        _dispatcher.Dispatch(new DeleteBoardAction(name));
    }
}
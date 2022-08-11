using Fluxor;
using KanBanApp.Store.Actions.Delete;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Facade;

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

    public void DeleteBoard(string name)
    {
        _dispatcher.Dispatch(new DeleteKanBanAction(name));
    }
}
using Fluxor;
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
}
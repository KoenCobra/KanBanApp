using Fluxor;
using KanBanApp.Store.Actions;

namespace KanBanApp.Store.Effects;

public class LoadKanbanEffect : Effect<LoadKanbanAction>
{
    public override Task HandleAsync(LoadKanbanAction action, IDispatcher dispatcher)
    {
        throw new NotImplementedException();
    }
}
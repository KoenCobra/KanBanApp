using Fluxor;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Effects;

public class LoadTaskEffect : Effect<LoadTaskAction>
{
    public override Task HandleAsync(LoadTaskAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new LoadTaskSuccessAction(action.Task));
        return Task.CompletedTask;
    }
}
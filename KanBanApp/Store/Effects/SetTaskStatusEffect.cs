using Fluxor;
using KanBanApp.Store.Actions.SetTaskStatus;

namespace KanBanApp.Store.Effects;

public class SetTaskStatusEffect : Effect<SetTaskStatusAction>
{
    public override Task HandleAsync(SetTaskStatusAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new SetTaskStatusSuccessAction(action.Status));
        return Task.CompletedTask;
    }
}
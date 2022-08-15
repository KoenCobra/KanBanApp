using Fluxor;
using KanBanApp.Store.Actions.delete;

namespace KanBanApp.Store.Effects;

public class DeleteTaskEffect : Effect<DeleteTaskAction>
{
    public override Task HandleAsync(DeleteTaskAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new DeleteTaskSuccessAction(action.Task));
        return Task.CompletedTask;
    }
}
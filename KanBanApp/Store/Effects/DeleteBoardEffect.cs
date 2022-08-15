using Fluxor;
using KanBanApp.Store.Actions.Delete;

namespace KanBanApp.Store.Effects;

public class DeleteBoardEffect : Effect<DeleteBoardAction>
{
    public override Task HandleAsync(DeleteBoardAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new DeleteBoardSuccessAction(action.Name));
        return Task.CompletedTask;
    }
}
using Fluxor;
using KanBanApp.Store.Actions.Create;

namespace KanBanApp.Store.Effects;

public class CreateBoardEffect : Effect<CreateBoardAction>
{
    public override Task HandleAsync(CreateBoardAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new CreateBoardSuccessAction(action.Board));
        return Task.CompletedTask;
    }
}
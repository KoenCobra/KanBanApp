using Fluxor;
using KanBanApp.Store.Actions.Update;

namespace KanBanApp.Store.Effects
{
    public class UpdateBoardEffect : Effect<UpdateBoardAction>
    {
        public override Task HandleAsync(UpdateBoardAction action, IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new UpdateBoardSuccessAction(action.Board));
            return Task.CompletedTask;
        }
    }
}

using Fluxor;
using KanBanApp.Store.Actions.SetCurrentBoard;

namespace KanBanApp.Store.Effects
{
    public class SetCurrentBoardEffect : Effect<SetCurrentBoardAction>
    {
        public override Task HandleAsync(SetCurrentBoardAction action, IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new SetCurrentBoardSuccessAction(action.Name));
            return Task.CompletedTask;
        }
    }
}

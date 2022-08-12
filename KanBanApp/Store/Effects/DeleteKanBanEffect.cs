using Fluxor;
using KanBanApp.Store.Actions.Delete;

namespace KanBanApp.Store.Effects;

public class DeleteKanBanEffect : Effect<DeleteKanBanAction>
{

    public override async System.Threading.Tasks.Task HandleAsync(DeleteKanBanAction action, IDispatcher dispatcher)
    {
        //await _kanbanApi.DeleteBoard(action.Board, action.Name);
        dispatcher.Dispatch(new DeleteKanBanSuccessAction(action.Name));
    }
}
using Fluxor;
using KanBanApp.Sdk.Abstractions;
using KanBanApp.Store.Actions.Delete;

namespace KanBanApp.Store.Effects;

public class DeleteKanBanEffect : Effect<DeleteKanBanAction>
{
    private readonly IKanBanApi _kanbanApi;

    public DeleteKanBanEffect(IKanBanApi kanbanApi)
    {
        _kanbanApi = kanbanApi;
    }

    public override async Task HandleAsync(DeleteKanBanAction action, IDispatcher dispatcher)
    {
        //await _kanbanApi.DeleteBoard(action.Board, action.Name);
        dispatcher.Dispatch(new DeleteKanBanSuccessAction(action.Name));
    }
}
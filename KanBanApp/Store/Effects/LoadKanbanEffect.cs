using Fluxor;
using KanBanApp.Sdk.Abstractions;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Effects;

public class LoadKanbanEffect : Effect<LoadKanbanAction>
{
    private readonly IKanBanApi _kanbanApi;

    public LoadKanbanEffect(IKanBanApi kanbanApi)
    {
        _kanbanApi = kanbanApi;
    }

    public override async Task HandleAsync(LoadKanbanAction action, IDispatcher dispatcher)
    {
        //dispatcher.Dispatch(new LoadKanbanSuccessAction(await _kanbanApi.GetKanbanRootObject()));
    }
}
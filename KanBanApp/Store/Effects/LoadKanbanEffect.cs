using Fluxor;
using KanbanApp.Models;
using KanBanApp.Sdk.Abstractions;
using KanBanApp.Store.Actions.Load;
using Task = System.Threading.Tasks.Task;

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
        var response = await _kanbanApi.GetAsync<KanBanObject>("db");
        //dispatcher.Dispatch(new LoadKanbanSuccessAction(await _kanbanApi.GetKanbanRootObject()));
    }
}
using System.Net.Http.Json;
using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Load;

namespace KanBanApp.Store.Effects;

public class LoadKanbanEffect : Effect<LoadKanbanAction>
{
    private readonly HttpClient _httpClient;

    public LoadKanbanEffect(HttpClient kanbanApi)
    {
        _httpClient = kanbanApi;
    }

    public override async System.Threading.Tasks.Task HandleAsync(LoadKanbanAction action, IDispatcher dispatcher)
    {
        var response = await _httpClient.GetFromJsonAsync<KanBanObject>("data.json"); ;

        dispatcher.Dispatch(new LoadKanbanSuccessAction(response));
    }
}
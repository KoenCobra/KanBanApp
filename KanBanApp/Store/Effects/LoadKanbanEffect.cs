using System.Net.Http.Json;
using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Load;
using Task = System.Threading.Tasks.Task;

namespace KanBanApp.Store.Effects;

public class LoadKanbanEffect : Effect<LoadKanbanAction>
{
    private readonly HttpClient _httpClient;

    public LoadKanbanEffect(HttpClient kanbanApi)
    {
        _httpClient = kanbanApi;
    }

    public override async Task HandleAsync(LoadKanbanAction action, IDispatcher dispatcher)
    {
        var response = await _httpClient.GetFromJsonAsync<KanBanObject>("data.json");

        if (response != null)
        {
            var boards = response.boards;
            dispatcher.Dispatch(new LoadKanbanSuccessAction(boards));
        }
    }
}
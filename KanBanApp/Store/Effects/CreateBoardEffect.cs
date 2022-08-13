using System.Net.Http.Json;
using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;
using Task = System.Threading.Tasks.Task;

namespace KanBanApp.Store.Effects;

public class CreateBoardEffect : Effect<CreateBoardAction>
{
    private readonly HttpClient _httpClient;

    public CreateBoardEffect(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public override Task HandleAsync(CreateBoardAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new CreateBoardSuccessAction(action.Board));
        return Task.CompletedTask;
    }
}
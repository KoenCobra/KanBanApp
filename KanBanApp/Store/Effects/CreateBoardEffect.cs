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

    public override async Task HandleAsync(CreateBoardAction action, IDispatcher dispatcher)
    {
        var createResponse = await _httpClient.PostAsJsonAsync("data.json", action.Board);

        if (!createResponse.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Error creating board: {createResponse.ReasonPhrase}");
        }

        var createdBoard = await createResponse.Content.ReadFromJsonAsync<Board>();

        dispatcher.Dispatch(new CreateBoardSuccessAction(action.Board));
    }
}
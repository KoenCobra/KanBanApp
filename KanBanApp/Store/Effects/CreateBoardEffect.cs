using System.Net.Http.Json;
using Fluxor;
using KanBanApp.Models;
using KanBanApp.Store.Actions.Create;

namespace KanBanApp.Store.Effects
{
    public class CreateBoardEffect: Effect<CreateBoardAction>
    {
        private readonly HttpClient _httpClient;


        public CreateBoardEffect(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public override async System.Threading.Tasks.Task HandleAsync(CreateBoardAction action, IDispatcher dispatcher)
        {
            var response = await _httpClient.PostAsJsonAsync("data.json", action.Board);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error creating board: {response.ReasonPhrase}");
            }

            var createdBoard = await response.Content.ReadFromJsonAsync<Board>();

            dispatcher.Dispatch(new CreateBoardSuccessAction(createdBoard));
        }
    }
}

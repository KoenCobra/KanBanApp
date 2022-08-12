using System.Net.Http.Json;
using KanBanApp.Services.Abstractions;
using KanBanApp.Store;

namespace KanBanApp.Services;

public class KanbanService : IKanbanService
{
    private readonly HttpClient _httpClient;

    public KanbanService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<TResponse?> GetAsync<TResponse>(string path)
    {
        return _httpClient.GetFromJsonAsync<TResponse>(path);
    }

    public Task<HttpResponseMessage> PostAsync<TBody>(string path, TBody body)
    {
        return _httpClient.PostAsJsonAsync(path, body);
    }

    public Task<HttpResponseMessage> PutAsync<TBody>(string path, TBody body)
    {
        return _httpClient.PutAsJsonAsync(path, body);
    }

    public void Delete(string name, KanbanState state)
    {
        var board = state.Boards.boards.FirstOrDefault(b => b.name == name);

        if (board != null) state.Boards.boards.Remove(board);
    }
}
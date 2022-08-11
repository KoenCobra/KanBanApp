using System.Net.Http.Json;
using KanbanApp.Models;
using KanBanApp.Sdk.Abstractions;

namespace KanBanApp.Sdk;

public class KanbanApi : IKanBanApi
{
    private readonly HttpClient _httpClient;

    public KanbanApi(HttpClient httpClient)
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

    public Task<HttpResponseMessage> DeleteAsync(string path)
    {
        return _httpClient.DeleteAsync(path);
    }
}
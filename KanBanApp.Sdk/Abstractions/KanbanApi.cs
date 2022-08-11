using KanbanApp.Models;

namespace KanBanApp.Sdk.Abstractions;

public interface IKanBanApi
{
    Task<TResponse> GetAsync<TResponse>(string path);
    Task<HttpResponseMessage> PostAsync<TBody>(string path, TBody body);
    Task<HttpResponseMessage> PutAsync<TBody>(string path, TBody body);
    Task<HttpResponseMessage> DeleteAsync(string path);
}
using KanBanApp.Store;

namespace KanBanApp.Services.Abstractions;

public interface IKanbanService
{
    Task<TResponse?> GetAsync<TResponse>(string path);
    Task<HttpResponseMessage> PostAsync<TBody>(string path, TBody body);
    Task<HttpResponseMessage> PutAsync<TBody>(string path, TBody body);
    Task<HttpResponseMessage> DeleteAsync(string path);
    void Delete(string name, KanbanState state);
}
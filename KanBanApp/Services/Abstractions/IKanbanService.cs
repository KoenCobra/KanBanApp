using KanBanApp.Models;

namespace KanBanApp.Services.Abstractions;

public interface IKanbanService
{
    IEnumerable<Board>? GetBoardDetails(string name);
    void Delete(string name);
}
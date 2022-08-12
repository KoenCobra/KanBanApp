using Fluxor;
using KanBanApp.Models;
using KanBanApp.Services.Abstractions;
using KanBanApp.Store;

namespace KanBanApp.Services;

public class KanbanService : IKanbanService
{
    private readonly IState<KanbanState>? _state;

    public KanbanService(IState<KanbanState>? state)
    {
        _state = state;
    }

    public IEnumerable<Board>? GetBoardDetails(string name)
    {
        if (_state != null && _state.Value.Boards != null && _state.Value.Boards.boards != null)
            return _state.Value.Boards.boards.Where(b => b.name == name);

        return new List<Board>();
    }

    public void Delete(string name)
    {
        if (_state != null && _state.Value.Boards != null && _state.Value.Boards.boards != null)
        {
            var board = _state.Value.Boards.boards.FirstOrDefault(b => b.name == name);

            if (board != null) _state.Value.Boards.boards.Remove(board);
        }
    }
}
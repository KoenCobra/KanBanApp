namespace KanBanApp.Store.Actions.delete;

public class DeleteBoardAction
{
    public DeleteBoardAction(string? name)
    {
        Name = name;
    }

    public string? Name { get; }
}
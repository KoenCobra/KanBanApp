namespace KanBanApp.Store.Actions.Delete;

public class DeleteBoardAction
{
    public DeleteBoardAction(string? name)
    {
        Name = name;
    }

    public string? Name { get; }
}
namespace KanBanApp.Store.Actions.Delete;

public class DeleteBoardSuccessAction
{
    public DeleteBoardSuccessAction(string? name)
    {
        Name = name;
    }

    public string? Name { get; }
}
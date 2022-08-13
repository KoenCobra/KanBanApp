namespace KanBanApp.Store.Actions.delete;

public class DeleteBoardSuccessAction
{
    public DeleteBoardSuccessAction(string? name)
    {
        Name = name;
    }

    public string? Name { get; }
}
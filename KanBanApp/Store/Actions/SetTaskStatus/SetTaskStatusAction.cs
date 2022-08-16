namespace KanBanApp.Store.Actions.SetTaskStatus;

public class SetTaskStatusAction
{
    public SetTaskStatusAction(string? status)
    {
        Status = status;
    }

    public string? Status { get; }
}
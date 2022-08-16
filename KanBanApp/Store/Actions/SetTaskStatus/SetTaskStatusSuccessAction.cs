namespace KanBanApp.Store.Actions.SetTaskStatus;

public class SetTaskStatusSuccessAction
{
    public SetTaskStatusSuccessAction(string? status)
    {
        Status = status;
    }

    public string? Status { get; }
}
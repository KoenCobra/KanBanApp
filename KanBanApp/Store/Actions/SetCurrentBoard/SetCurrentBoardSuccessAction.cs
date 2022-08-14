namespace KanBanApp.Store.Actions.SetCurrentBoard
{
    public class SetCurrentBoardSuccessAction
    {
        public SetCurrentBoardSuccessAction(string? name)
        {
            Name = name;
        }

        public string? Name { get; }
    }
}

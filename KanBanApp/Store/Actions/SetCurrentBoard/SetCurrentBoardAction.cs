namespace KanBanApp.Store.Actions.SetCurrentBoard
{
    public class SetCurrentBoardAction
    {
        public SetCurrentBoardAction(string? name)
        {
            Name = name;
        }

        public string? Name { get; }
    }
}

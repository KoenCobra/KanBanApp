using Fluxor;

namespace KanBanApp.Store;

public class KanbanFeature : Feature<KanbanState>
{
    public override string GetName()
    {
        return "KanbanState";
    }

    protected override KanbanState GetInitialState()
    {
        return new KanbanState(null, null, null);
    }
}
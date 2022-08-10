using Fluxor;
using KanBanApp.Store.State;

namespace KanBanApp.Store.Feature;

public class KanbanFeature : Feature<KanbanState>
{
    public override string GetName()
    {
        return "KanbanState";
    }

    protected override KanbanState GetInitialState()
    {
        return new KanbanState(null, null);
    }
}
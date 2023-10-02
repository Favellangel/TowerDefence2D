
public class BtnUpgradeGoldBehavior : BtnSubscriber
{
    private GoldMinerUpdater goldMainerUpdater;

    protected override void Awake()
    {
        base.Awake();
        Player player = FindObjectOfType<Player>();
        goldMainerUpdater = player.GetComponent<GoldMinerUpdater>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        TryDeactivate();
    }

    protected override void Execute()
    {
        goldMainerUpdater.NextLvl();
        TryDeactivate();
    }

    private void TryDeactivate()
    {
        if (goldMainerUpdater.CanLvlUp()) return;

        btn.interactable = false;
    }
}


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
        Deactivate();
    }

    protected override void Execute()
    {
        goldMainerUpdater.NextLvl();
        Deactivate();
    }

    private void Deactivate()
    {
        if (goldMainerUpdater.CanLvlUp()) return;

        btn.interactable = false;
    }
}

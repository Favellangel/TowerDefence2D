public class CurrentGoldTxt : TxtMeshUpdater
{
    private GoldComponent goldComponent;

    protected override void Awake()
    {
        base.Awake();

        Player player = FindObjectOfType<Player>(true);
        goldComponent = player.GetComponent<GoldComponent>();

        currentTxt = goldComponent.GoldTxt;
        onChange = goldComponent.OnChangeGold;
    }
}

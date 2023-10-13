using UnityEngine;

public class BtnTowerFireRateUpgrade : BtnSubscriber
{
    [SerializeField] private int cost;
    [SerializeField] private int fireRateAdded;

    private GoldComponent goldComponent;
    private PanelUpgradeController panelUpgrade;

    protected override void Awake()
    {
        base.Awake();

        Player player = FindObjectOfType<Player>(true);
        goldComponent = player.GetComponent<GoldComponent>();
        panelUpgrade = GetComponentInParent<PanelUpgradeController>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        if (panelUpgrade.Tower.ShootComponent.IsMaxLvl()) 
            btn.interactable = false;
        else
            btn.interactable = true;
    }

    protected override void Execute()
    {
        if (panelUpgrade.Tower == false) return;
        if (goldComponent.SubGold(cost) == false) return;

        if (panelUpgrade.Tower.ShootComponent.IsMaxLvl()) 
        {
            btn.interactable = false;
            return;
        }

        panelUpgrade.Tower.ShootComponent.DeacreaseFireRate(fireRateAdded);
    }
}

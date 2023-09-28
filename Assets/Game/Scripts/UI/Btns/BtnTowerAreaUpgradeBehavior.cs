using UnityEngine;

public class BtnTowerAreaUpgradeBehavior : BtnSubscriber
{
    [SerializeField] private int cost;
    [SerializeField] private int radiusAttackAdded;

    private GoldComponent goldComponent;
    private PanelUpgradeController panelUpgrade;

    protected override void Awake()
    {
        base.Awake();
        panelUpgrade = GetComponentInParent<PanelUpgradeController>();
        Player player = FindObjectOfType<Player>(true);
        goldComponent = player.GetComponent<GoldComponent>();
    }

    protected override void Execute()
    {
        if (panelUpgrade.Tower == false) return;
        if (goldComponent.SubGold(cost) == false) return;
        
        bool isUpgrade = panelUpgrade.Tower.RadiusAttackComponent.Increase(radiusAttackAdded);

        if (isUpgrade == false) btn.interactable = false;
    }
}

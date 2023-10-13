using UnityEngine;

public class BtnTowerAreaUpgrade : BtnSubscriber
{
    [SerializeField] private int cost;
    [SerializeField] private int radiusAttackAdded;

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

        if (panelUpgrade.Tower.RadiusAttack.IsMaxLvl())
            btn.interactable = false;
        else
            btn.interactable = true;
    }

    protected override void Execute()
    {
        if (panelUpgrade.Tower == false) return;
        if (goldComponent.SubGold(cost) == false) return;        

        if (panelUpgrade.Tower.RadiusAttack.IsMaxLvl())
        {
            btn.interactable = false;
            return;
        }

        panelUpgrade.Tower.RadiusAttack.Increase(radiusAttackAdded);
    }
}

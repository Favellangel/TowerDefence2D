using UnityEngine;

public class BtnSellTowerBehavior : BtnSubscriber
{
    [SerializeField] private int sellingPrice;

    private GoldComponent goldComponent;
    private PanelUpgradeController panelUpgradeController;

    protected override void OnEnable()
    {
        base.OnEnable();
        Player player = FindObjectOfType<Player>();
        goldComponent = player.GetComponent<GoldComponent>();
        panelUpgradeController = GetComponentInParent<PanelUpgradeController>();
    }
    protected override void Execute()
    {
        goldComponent.AddGold(sellingPrice);
        panelUpgradeController.SellTower();
        panelUpgradeController.Tower.EnableTowerPlace();
        transform.parent.gameObject.SetActive(false);
    }
}

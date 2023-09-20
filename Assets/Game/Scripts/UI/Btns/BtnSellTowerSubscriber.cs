using UnityEngine;

public class BtnSellTowerSubscriber : BtnSubscriber
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
        if (goldComponent.AddGold(sellingPrice))
            panelUpgradeController.SellTower();

        transform.parent.gameObject.SetActive(false);
    }
}

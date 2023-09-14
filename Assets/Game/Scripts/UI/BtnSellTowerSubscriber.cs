using UnityEngine;
using UnityEngine.UI;

public class BtnSellTowerSubscriber : MonoBehaviour
{
    [SerializeField] private int sellingPrice;

    private GoldComponent goldComponent;
    private PanelUpgradeController panelUpgradeController;

    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(Execute);
        panelUpgradeController = GetComponentInParent<PanelUpgradeController>();

        goldComponent = FindObjectOfType<GoldComponent>(true);
    }

    private void Execute()
    {
        if(goldComponent.AddGold(sellingPrice))
        {
            print(1);
            panelUpgradeController.SellTower();
        }


        transform.parent.gameObject.SetActive(false);
    }
}

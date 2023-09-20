using UnityEngine;

public class BtnBuildTowerSubcriber : BtnSubscriber
{
    [SerializeField] private int costTower;
    [SerializeField] private GameObject tower;

    private GoldComponent goldComponent;    
    private PanelBuildTowerController panelBuildTowerController;

    protected override void OnEnable()
    {
        base.OnEnable();
        Player player = FindObjectOfType<Player>();
        goldComponent = player.GetComponent<GoldComponent>();
        panelBuildTowerController = FindObjectOfType<PanelBuildTowerController>(true);
    }

    protected override void Execute()
    {
        if (goldComponent.SubGold(costTower))
        {
            Instantiate(tower, panelBuildTowerController.transform.position, Quaternion.identity);
        }

        transform.parent.gameObject.SetActive(false);
    }
}

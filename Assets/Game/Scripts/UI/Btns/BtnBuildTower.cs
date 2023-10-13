using UnityEngine;

public class BtnBuildTower : BtnSubscriber
{
    [SerializeField] private int costTower;
    [SerializeField] private GameObject towerPrefab;

    private GoldComponent goldComponent;
    private TowerPlaceSelected towerPlaceSelected;
    private PanelBuildTowerController panelBuildTowerController;

    protected override void Awake()
    {
        base.Awake();

        Player player = FindObjectOfType<Player>();
        goldComponent = player.GetComponent<GoldComponent>();
        towerPlaceSelected = FindObjectOfType<TowerPlaceSelected>();
        panelBuildTowerController = FindObjectOfType<PanelBuildTowerController>(true);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    protected override void Execute()
    {
        if (goldComponent.SubGold(costTower))
        {
            GameObject tower = Instantiate(towerPrefab, panelBuildTowerController.transform.position, Quaternion.identity);
            tower.GetComponent<Tower>().SetTowerPlace(towerPlaceSelected.Collider);
            towerPlaceSelected.Disable();
        }

        transform.parent.gameObject.SetActive(false);
    }
}

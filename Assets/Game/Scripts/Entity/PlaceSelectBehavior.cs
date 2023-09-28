using UnityEngine;

public class PlaceSelectBehavior : MonoBehaviour, ISelecteble
{
    private Transform _transform;
    private Collider2D _collider;

    private PanelSelected currentPanel;
    private TowerPlaceSelected towerPlaceSelected;
    private PanelBuildTowerController panelBuildTowerController;

    private void Awake()
    {
        _transform = transform;
        _collider = GetComponent<Collider2D>();

        currentPanel = FindObjectOfType<PanelSelected>();
        towerPlaceSelected = FindObjectOfType<TowerPlaceSelected>();
        panelBuildTowerController = FindObjectOfType<PanelBuildTowerController>(true);
    }

    public void Deselect()
    {
        panelBuildTowerController.Show(false);
        currentPanel.Set(null);
        towerPlaceSelected.Set(null);
    }

    public void Select()
    {
        panelBuildTowerController.SetPanelPosition(_transform.position);
        panelBuildTowerController.Show(true);
        currentPanel.Set(panelBuildTowerController.gameObject);
        towerPlaceSelected.Set(_collider);
    }
}
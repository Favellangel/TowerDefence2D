using UnityEngine;

public class PlaceSelectBehavior : MonoBehaviour, ISelecteble
{
    private Transform _transform;

    private PanelMomentor panelMomentor;
    private PanelBuildTowerController panelBuildTowerController;

    private void Awake()
    {
        _transform = transform;
        panelMomentor = FindObjectOfType<PanelMomentor>();
        panelBuildTowerController = FindObjectOfType<PanelBuildTowerController>(true);
    }

    public void Deselect()
    {
        panelBuildTowerController.Show(false);
        panelMomentor.Set(null);
    }

    public void Select()
    {
        panelBuildTowerController.SetPanelPosition(_transform.position);
        panelBuildTowerController.Show(true);
        panelMomentor.Set(panelBuildTowerController.gameObject);
    }
}
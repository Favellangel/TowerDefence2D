using UnityEngine;

public class TowerSelectBehavior : MonoBehaviour, ISelecteble
{
    private Transform _transform;
    private GameObject _gameObject;

    private PanelMomentor panelMomentor; 
    private SpriteRenderer affectedArea;
    private PanelUpgradeController panelUpgradeController;

    private void Awake()
    {
        _transform = transform;
        _gameObject = gameObject;

        panelUpgradeController = FindObjectOfType<PanelUpgradeController>(true);
        RadiusAttackOnEnable script = GetComponentInChildren<RadiusAttackOnEnable>();
        affectedArea = script.GetComponent<SpriteRenderer>();
        panelMomentor = FindObjectOfType<PanelMomentor>();
    }

    public void Selected(bool isSelect)
    {
        panelUpgradeController.Show(isSelect);
        if (affectedArea == null) return;
        affectedArea.enabled = isSelect;
    }

    public void Select()
    {
        panelUpgradeController.SetPanelPosition(_transform.position);
        panelUpgradeController.SetTower(_gameObject);
        panelMomentor.Set(panelUpgradeController.gameObject);
        Selected(true);
    }

    public void Deselect()
    {
        Selected(false);
        panelMomentor.Set(null);
    }
}
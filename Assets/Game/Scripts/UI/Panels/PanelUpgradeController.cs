using UnityEngine;

public class PanelUpgradeController : Panelmoving
{
    private GameObject currentTower;
    private Tower tower;

    public Tower Tower => tower;


    public void SetTower(GameObject towerObject)
    {
        currentTower = towerObject;
        tower = currentTower.GetComponent<Tower>();
    }

    public void SellTower()
    {
        Destroy(currentTower);
        gameObject.SetActive(false);
    }
}

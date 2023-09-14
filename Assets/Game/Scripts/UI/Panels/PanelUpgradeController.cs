using UnityEngine;

public class PanelUpgradeController : Panel
{
    private GameObject currentTower;

    public void SetTower(GameObject tower)
    {
        currentTower = tower;
    }

    public void SellTower()
    {
        Destroy(currentTower);
        gameObject.SetActive(false);
    }
}

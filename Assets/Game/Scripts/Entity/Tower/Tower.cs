using UnityEngine;

public class Tower : MonoBehaviour
{
    private Collider2D towerPlaceCollider;
    private RadiusAttackComponent radiusAttackComponent;

    public RadiusAttackComponent RadiusAttackComponent => radiusAttackComponent;

    private void Awake()
    {
        radiusAttackComponent = GetComponentInChildren<RadiusAttackComponent>();
    }

    public void SetTowerPlace(Collider2D towerPlaceCollider)
    {
        this.towerPlaceCollider = towerPlaceCollider;
    }

    public void EnableTowerPlace()
    {
        towerPlaceCollider.enabled = true;
    }
}

using UnityEngine;

public class Tower : MonoBehaviour
{
    private Collider2D towerPlaceCollider;

    private ShootComponent shootComponent;
    private RadiusAttackComponent radiusAttack;

    public ShootComponent ShootComponent => shootComponent;
    public RadiusAttackComponent RadiusAttack => radiusAttack;


    private void Awake()
    {
        shootComponent = GetComponentInChildren<ShootComponent>();
        radiusAttack = GetComponentInChildren<RadiusAttackComponent>();
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

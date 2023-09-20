using UnityEngine;

public class Tower : MonoBehaviour
{
    private RadiusAttackComponent radiusAttackComponent;

    public RadiusAttackComponent RadiusAttackComponent => radiusAttackComponent;

    private void Awake()
    {
        radiusAttackComponent = GetComponentInChildren<RadiusAttackComponent>();
    }
}

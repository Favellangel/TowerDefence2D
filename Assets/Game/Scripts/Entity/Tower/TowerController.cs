using UnityEngine;

public class TowerController : MonoBehaviour
{
    private ShootComponent shootComponent;
    private RotateComponent rotateComponent;
    private FindTargetComponent findTargetComponent;


    private void Awake()
    {
        shootComponent = GetComponentInChildren<ShootComponent>();
        rotateComponent = GetComponentInChildren<RotateComponent>();
        findTargetComponent = GetComponentInChildren<FindTargetComponent>();
    }

    private void Update()
    {
        if (findTargetComponent.Count <= 0)
        {
            rotateComponent.Rotate(transform.position);
            return;
        }

        rotateComponent.Rotate(findTargetComponent.GetTarget(0).transform.position);
        shootComponent.Shoot();
    }
}

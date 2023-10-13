using UnityEngine;

public class TowerArcherController : MonoBehaviour
{
    private ShootComponent shootComponent;
    private RotateComponent rotateComponent;
    private FindTargetBehavior findTarget;

    private void Awake()
    {
        shootComponent = GetComponentInChildren<ShootComponent>();
        rotateComponent = GetComponentInChildren<RotateComponent>();
        findTarget = GetComponentInChildren<FindTargetBehavior>();
    }

    private void Update()
    {
        if(findTarget.Target == null)
        {
            rotateComponent.Rotate(transform.position);
            return;
        }

        rotateComponent.Rotate(findTarget.Target.transform.position);
        shootComponent.Shoot();
    }
}

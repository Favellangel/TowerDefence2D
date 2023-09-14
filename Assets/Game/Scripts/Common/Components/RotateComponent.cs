using UnityEngine;

public class RotateComponent : MonoBehaviour
{

    public void Rotate(Vector3 target)
    {
        Vector2 direction = target - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle));
    }
}

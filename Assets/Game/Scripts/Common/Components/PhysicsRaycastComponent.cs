using UnityEngine;

public class PhysicsRaycastComponent 
{
    private Ray ray;
    private RaycastHit2D hit;

    private Camera _camera;

    public RaycastHit2D Hit => hit;

    public PhysicsRaycastComponent(Camera camera)
    {
        _camera = camera;
    }

    public void IsClickToCollider()
    {
        ray = _camera.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, 100);
    }
}

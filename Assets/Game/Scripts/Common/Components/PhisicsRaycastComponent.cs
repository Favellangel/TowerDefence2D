using UnityEngine;

public class PhisicsRaycastComponent 
{
    private Ray ray;
    private RaycastHit2D hit;

    private Camera _camera;

    public RaycastHit2D Hit => hit;

    public PhisicsRaycastComponent(Vector3 origin)
    {
        _camera = Camera.main;
        ray.origin = origin;
    }

    public void IsClickToCollider()
    {
        ray = _camera.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, 100);
    }
}

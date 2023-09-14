using UnityEngine;

public abstract class Panel : MonoBehaviour, IAwakable
{
    private Camera camera;
    private Transform _transform;

    public void Initialize()
    {
        camera = Camera.main;
        _transform = transform;
    }

    public void SetPanelPosition(Vector3 position)
    {
        Vector2 pos = position; //camera.WorldToScreenPoint(position);
        _transform.position = pos;
    }

    public void Show(bool isShow)
    {
        gameObject.SetActive(isShow);
    }
}

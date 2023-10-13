using UnityEngine;

public abstract class Panelmoving : MonoBehaviour, IAwakable
{
    private Transform _transform;

    public void Initialize()
    {
        _transform = transform;
    }

    public void SetPanelPosition(Vector3 position)
    {
        Vector2 pos = position; 
        _transform.position = pos;
    }

    public void Show(bool isShow)
    {
        gameObject.SetActive(isShow);
    }
}

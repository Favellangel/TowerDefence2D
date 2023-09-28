using UnityEngine;

public class TowerPlaceSelected : MonoBehaviour
{
    private Collider2D _collider;
    private GameObject towerPlace;

    public Collider2D Collider => _collider;

    public void Set(Collider2D collider)
    {
        _collider = collider;
    }

    public void Disable()
    {
        if (_collider == null) return;
        _collider.enabled = false;
    }
}

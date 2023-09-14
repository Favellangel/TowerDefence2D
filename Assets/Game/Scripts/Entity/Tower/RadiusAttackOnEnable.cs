using UnityEngine;

public class RadiusAttackOnEnable : MonoBehaviour
{
    [SerializeField] private float radiusAttack;

    private void OnEnable()
    {
        transform.localScale = Vector2.one * radiusAttack;
    }
}

using UnityEngine;

public class TakeDamageWallBehavior : MonoBehaviour, IDamageble
{
    private HealthComponent healthComponent;

    private void Awake()
    {
        healthComponent = GetComponent<HealthComponent>();
    }

    public void TakeDamage(int damage)
    {
        healthComponent.TakeDamage(damage);
    }
}

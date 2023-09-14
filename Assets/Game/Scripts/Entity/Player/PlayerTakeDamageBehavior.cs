using UnityEngine;

public class PlayerTakeDamageBehavior : MonoBehaviour, IDamageble
{
    private HealthComponent healthComponent;

    private void Awake()
    {
        GoldComponent goldComponent = FindObjectOfType<GoldComponent>(true);
        healthComponent = goldComponent.GetComponent<HealthComponent>();
    }

    public void TakeDamage(int damage)
    {
        healthComponent?.TakeDamage(damage);
    }
}

using UnityEngine;

public class PlayerTakeDamageBehavior : MonoBehaviour, IDamageble
{
    private HealthComponent healthComponent;

    private void Awake()
    {
        Player player = FindObjectOfType<Player>();
        healthComponent = player.GetComponent<HealthComponent>();
    }

    public void TakeDamage(int damage)
    {
        healthComponent?.TakeDamage(damage);
    }
}

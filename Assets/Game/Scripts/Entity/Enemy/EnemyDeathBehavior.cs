using UnityEngine;

public class EnemyDeathBehavior : MonoBehaviour
{
    [SerializeField] private float delayDeath;

    private Collider2D _collider2D;
    private EnemyStateMachine enemy;
    private HealthComponent healthComponent;


    private void Awake()
    {
        _collider2D = GetComponent<Collider2D>();
        enemy = GetComponent<EnemyStateMachine>();
        healthComponent = GetComponent<HealthComponent>();
    }

    private void OnEnable()
    {
        healthComponent.AddActionOnDie(Death);
    }

    private void OnDisable()
    {
        healthComponent.RemoveActionOnDie(Death);
    }

    private void OnDestroy()
    {
        healthComponent.RemoveActionOnDie(Death);
    }

    private void Death()
    {
        _collider2D.enabled = false;
        enemy.enabled = false;
        Invoke(nameof(Kill), delayDeath);
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}

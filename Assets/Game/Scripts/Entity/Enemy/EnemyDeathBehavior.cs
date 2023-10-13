using UnityEngine;

public class EnemyDeathBehavior : Subscriber, IAwakable
{
    [SerializeField] private float delayDeath;

    private Collider2D _collider2D;
    private EnemyStateMachine enemyState;

    public void Initialize()
    {
        onAction = GetComponent<HealthComponent>();
        _collider2D = GetComponent<Collider2D>();
        enemyState = GetComponent<EnemyStateMachine>();
    }

    public override void Execute()
    {
        _collider2D.enabled = false;
        enemyState.enabled = false;
        Invoke(nameof(Kill), delayDeath);
    }

    private void Kill()
    {
        gameObject.SetActive(false);
    }
}

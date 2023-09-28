using UnityEngine;

public class EnemyDeathBehavior : MonoBehaviour
{
    [SerializeField] private float delayDeath;

    private IEventable onDie;
    private Collider2D _collider2D;
    private EnemyStateMachine enemyState;


    private void Awake()
    {
        onDie = GetComponent<HealthComponent>();
        _collider2D = GetComponent<Collider2D>();
        enemyState = GetComponent<EnemyStateMachine>();
    }

    private void OnEnable()
    {
        onDie.AddAction(Death);
    }

    private void OnDisable()
    {
        onDie.RemoveAction(Death);
    }

    private void OnDestroy()
    {
        onDie.RemoveAction(Death);
    }

    private void Death()
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

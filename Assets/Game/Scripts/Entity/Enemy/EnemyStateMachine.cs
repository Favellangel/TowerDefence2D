using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    private State currentState;

    private Enemy_IDLE_Behabior state_IDLE;
    private EnemyAttackBehavior state_Attack;

    private EnemyMovement enemyMovement;
    private MakeDamageBehavior damageBehavior;
    private ChechCollisionComponent chechCollisionComponent;

    private void Awake()
    {
        enemyMovement = GetComponent<EnemyMovement>();
        damageBehavior = GetComponent<MakeDamageBehavior>();
        chechCollisionComponent = GetComponent<ChechCollisionComponent>();
        
        state_IDLE = new Enemy_IDLE_Behabior(enemyMovement, chechCollisionComponent);
        state_Attack = new EnemyAttackBehavior(damageBehavior, chechCollisionComponent);

        state_IDLE.Initialize(state_Attack);
        state_Attack.Initialize(state_IDLE);

        currentState = state_IDLE;
    }

    private void OnEnable()
    {
        currentState.AddAction(ChangeState);
    }

    private void OnDestroy()
    {
        currentState.RemoveAction(ChangeState);
    }

    private void OnDisable()
    {
        currentState.RemoveAction(ChangeState);
    }

    private void Update()
    {
        currentState.Update();
    }

    private void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

    private void ChangeState(State nextState)
    {
        currentState.Exit();
        currentState.RemoveAction(ChangeState);

        currentState = nextState;
        currentState.Enter();
        currentState.AddAction(ChangeState);
    }
}


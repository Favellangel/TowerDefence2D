using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    private State currentState;

    private Enemy_IDLE_Behabior state_IDLE;
    private EnemyAttackBehavior state_Attack;

    private EnemyMovement enemyMovement;
    private MakeDamageAndDestroyBehavior damageBehavior;
    private CollisionComponent chechCollisionComponent;

    private void Awake()
    {
        enemyMovement = GetComponent<EnemyMovement>();
        damageBehavior = GetComponent<MakeDamageAndDestroyBehavior>();
        chechCollisionComponent = GetComponent<CollisionComponent>();
        
        state_IDLE = new Enemy_IDLE_Behabior(enemyMovement, chechCollisionComponent);
        state_Attack = new EnemyAttackBehavior(damageBehavior, chechCollisionComponent);

        state_IDLE.Bind(state_Attack);
        state_Attack.Bind(state_IDLE);

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
        //print(currentState.ToString());
    }
}



public class Enemy_IDLE_Behabior : State
{
    private EnemyMovement movement;
    private ChechCollisionComponent collisionComponent;
    private EnemyAttackBehavior state_Attack;

    public Enemy_IDLE_Behabior(EnemyMovement movement, ChechCollisionComponent collisionComponent)
    {
        this.movement = movement;
        this.collisionComponent = collisionComponent;
    }

    public void Initialize(EnemyAttackBehavior state)
    {
        state_Attack = state;
    }

    public override void Update()
    {
       if(collisionComponent.CheckCollision(movement.Direction, movement.Speed))        
            onChangeState?.Invoke(state_Attack);       
    }

    public override void FixedUpdate()
    {
        movement.Move();
    }

}

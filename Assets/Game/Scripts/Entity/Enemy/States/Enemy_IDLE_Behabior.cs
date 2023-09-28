
public class Enemy_IDLE_Behabior : State
{
    private EnemyMovement movement;
    private CollisionComponent collisionComponent;
    private EnemyAttackBehavior state_Attack;

    public Enemy_IDLE_Behabior(EnemyMovement movement, CollisionComponent collisionComponent)
    {
        this.movement = movement;
        this.collisionComponent = collisionComponent;
    }

    public void Bind(EnemyAttackBehavior state)
    {
        state_Attack = state;
    }

    public override void FixedUpdate()
    {
        if (collisionComponent.CheckCollision(movement.Direction, movement.Speed))
            onChangeState?.Invoke(state_Attack);

        movement.Move();
    }

}

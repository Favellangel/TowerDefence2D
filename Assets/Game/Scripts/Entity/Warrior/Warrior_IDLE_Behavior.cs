
public class Warrior_IDLE_Behavior : State
{
    private CollisionComponent collisionComponent;

    public Warrior_IDLE_Behavior(CollisionComponent collisionComponent)
    {
        this.collisionComponent = collisionComponent;
    }

    public override void FixedUpdate()
    {
    }
}

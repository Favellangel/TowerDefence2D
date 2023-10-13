
public class DeathWallBehavior : Subscriber
{
    protected void Awake()
    {
        onAction = GetComponent<HealthComponent>();
    }

    public override void Execute()
    {
        Destroy(gameObject);
    }
}

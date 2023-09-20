using UnityEngine;

public class EnemyAttackBehavior : State
{
    private float currentDelay;

    private Enemy_IDLE_Behabior state_IDLE;
    private MakeDamageBehavior damageBehavior;
    private ChechCollisionComponent collisionComponent;

    private IDamageble damageble;

    public EnemyAttackBehavior(MakeDamageBehavior damageBehavior, ChechCollisionComponent collisionComponent)
    {
        this.damageBehavior = damageBehavior;
        this.collisionComponent = collisionComponent;        
    }

    public void Initialize(Enemy_IDLE_Behabior state_IDLE)
    {
        this.state_IDLE = state_IDLE;
    }

    public override void Enter()
    {
        if (collisionComponent.TargetCollider == null)
            onChangeState?.Invoke(state_IDLE);

        if (collisionComponent.TargetCollider.TryGetComponent(out damageble) == false)
            onChangeState?.Invoke(state_IDLE);
    }

    public override void Update()
    {
        if (damageble.ToString() == Tags._null)
            onChangeState?.Invoke(state_IDLE);
        
        if (currentDelay <= 0)
        {
            damageble.TakeDamage(damageBehavior.Damage);
            currentDelay = damageBehavior.DelayAttack;
        }
        else
            currentDelay -= Time.deltaTime;
    }

    public override void Exit()
    {
        currentDelay = 0;
    }
}

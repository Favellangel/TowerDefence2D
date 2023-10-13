using UnityEngine;

public class FindTargetBehavior : MonoBehaviour
{
    private GameObject target;
    private PoolEnemies pool;

    private IEventable onDieTarget;

    private RadiusAttackComponent radiusAttackComponent;

    public GameObject Target => target;

    private void Awake()
    {
        pool = FindObjectOfType<PoolEnemies>();

        radiusAttackComponent = GetComponentInChildren<RadiusAttackComponent>();             
    }

    private void FixedUpdate()
    {
        if (target != null) return;

        for (int i = 0; i < pool.Enemies.Length; i++)
        {
            if (pool.Enemies[i].activeSelf == false) continue;
            if (pool.Enemies[i].GetComponent<Collider2D>().enabled == false) continue;
            if ((pool.Enemies[i].transform.position - transform.position).magnitude > radiusAttackComponent.RadiusAttack) continue;

            target = pool.Enemies[i];
            onDieTarget = target.GetComponent<HealthComponent>();

            if (onDieTarget == null) 
                DisTarget();
            else 
                onDieTarget.AddAction(DisTarget);
        }
    }

    private void DisTarget()
    {
       // print(onDieTarget.ToString());
        if(onDieTarget != null)
            onDieTarget.RemoveAction(DisTarget);

        onDieTarget = null;
        target = null;
    }


    /* Для обучения начать с этого
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.tag != Tags.enemy) return; 
        //enemies.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != Tags.enemy) return;
        enemies.Remove(collision.gameObject);
    }*/
}

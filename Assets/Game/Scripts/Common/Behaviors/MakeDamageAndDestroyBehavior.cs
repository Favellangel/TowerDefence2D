using UnityEngine;

public class MakeDamageAndDestroyBehavior : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float delayAttack;

    public int Damage => damage;
    public float DelayAttack => delayAttack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.TryGetComponent(out IDamageble damageble)) return;        

        damageble.TakeDamage(damage);
        Destroy(gameObject);        
    }
}

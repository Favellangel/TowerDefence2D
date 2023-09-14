using UnityEngine;

public class MakeDamageBehavior : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.TryGetComponent(out IDamageble damageble)) return;
        
        //IDamageble damageble = collision.GetComponent<IDamageble>();

        //if (damageble == null) return;

        damageble.TakeDamage(damage);
        Destroy(gameObject);
        
    }
}

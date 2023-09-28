using UnityEngine;

public class DeathWallBehavior : MonoBehaviour
{
    private IEventable onDie;

    private void Awake()
    {
        onDie = GetComponent<HealthComponent>();
    }
    private void OnEnable()
    {
        onDie.AddAction(Death);
    }

    private void OnDisable()
    {
        onDie.RemoveAction(Death);
    }

    private void OnDestroy()
    {
        onDie.RemoveAction(Death);
    }

    private void Death()
    {
        // Если отключать, тогда враги не потеряют ссылку на стену
       // gameObject.SetActive(false);

        Destroy(gameObject);
    }
}

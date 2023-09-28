using UnityEngine;

public class DeathWallBehavior : MonoBehaviour
{
    private HealthComponent healthComponent;

    private void Awake()
    {
        healthComponent = GetComponent<HealthComponent>();
    }
    private void OnEnable()
    {
        healthComponent.AddActionOnDie(Death);
    }

    private void OnDisable()
    {
        healthComponent.RemoveActionOnDie(Death);
    }

    private void OnDestroy()
    {
        healthComponent.RemoveActionOnDie(Death);
    }

    private void Death()
    {
        // Если отключать, тогда враги не потеряют ссылку на стену
       // gameObject.SetActive(false);

        Destroy(gameObject);
    }
}

using UnityEngine;

public class LifeTimeController : MonoBehaviour
{
    [SerializeField] private float lifeTime;

    private float currentDelay;

    private void OnEnable()
    {
        currentDelay = lifeTime;
    }

    private void Update()
    {
        if(currentDelay > 0)
            currentDelay -= Time.deltaTime;
        else
            Destroy(gameObject);
    }
}

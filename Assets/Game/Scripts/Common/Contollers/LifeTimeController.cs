using System.Collections;
using UnityEngine;

public class LifeTimeController : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private Transform target;   

    private void Awake()
    {
        target = transform;
    }

    private void OnEnable()
    {
        StartCoroutine(SelfDestroyTimer());
    }

    IEnumerator SelfDestroyTimer()
    {
        yield return new WaitForSeconds(_lifeTime);
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

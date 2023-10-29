using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    private void Start()
    {
#if !UNITY_EDITOR
    Destroy(gameObject);
#endif

    }
}

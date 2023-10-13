using UnityEngine;

public class DestroyOnStart_EDITOR : MonoBehaviour
{
    private void Start()
    {
#if !UNITY_EDITOR
    Destroy(gameObject);
#endif

    }
}

using UnityEngine;

public class HideObjectInHiearchy : MonoBehaviour
{
    private void Awake()
    {
        gameObject.hideFlags = HideFlags.HideInHierarchy;
    }
}

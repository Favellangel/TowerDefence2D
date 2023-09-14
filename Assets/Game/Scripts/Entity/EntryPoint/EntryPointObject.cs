using UnityEngine;

public class EntryPointObject : EntryPoint
{
    protected override void Awake()
    {
        monoBehaviours = GetComponentsInChildren<MonoBehaviour>();
        base.Awake();
    }
}

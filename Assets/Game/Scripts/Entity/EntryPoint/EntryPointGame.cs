using UnityEngine;

public class EntryPointGame : EntryPoint
{   
    protected override void Awake()
    {
        monoBehaviours = FindObjectsOfType<MonoBehaviour>(true);
        base.Awake();
    }
}

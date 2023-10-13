using UnityEngine;

public class EntryPointGame : EntryPoint
{   
    protected override void Awake()
    {
        GameTime.StartGame();
        monoBehaviours = FindObjectsOfType<MonoBehaviour>(true);
        base.Awake();
    }
}

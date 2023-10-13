using UnityEngine;

public class SaveLoadSystem : MonoBehaviour, IAwakable, IBindable
{
    private SaveLoadBehavior saveLoadBehavior;

    public void Initialize()
    {
        saveLoadBehavior = GetComponent<SaveLoadBehavior>();

        DontDestroyOnLoad(gameObject);
    }

    public void Bind()
    {
        saveLoadBehavior.LoadGame();
    }

    /*private void OnLevelWasLoaded(int level)
    {
        saveLoadBehavior.LoadGame();
    }    */
}

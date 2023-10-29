using UnityEngine;

public class SaveLoadSystem : MonoBehaviour, IAwakable, IBindable
{
    private SaveLoadBehavior saveLoadBehavior;

    public SaveLoadBehavior SaveLoadBehavior => saveLoadBehavior;

    public void Initialize()
    {
        saveLoadBehavior = new SaveLoadBehavior(FindObjectOfType<MenuDatasBehavior>());
    }

    public void Bind()
    {

        saveLoadBehavior.LoadGame();
    }
}

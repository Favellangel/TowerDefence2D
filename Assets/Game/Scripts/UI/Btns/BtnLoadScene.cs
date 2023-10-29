using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLoadScene : BtnSubscriber
{
    [SerializeField] private int sceneIndex;

    public void SetIndex(int sceneIndex)
    {
        this.sceneIndex = sceneIndex;
    }

    protected override void Execute()
    {
        //SceneManager.LoadScene(sceneIndex);
    }
}

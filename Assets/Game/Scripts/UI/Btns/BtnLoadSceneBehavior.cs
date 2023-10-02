using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLoadSceneBehavior : BtnSubscriber
{
    [SerializeField] private int sceneIndex;

    protected override void Execute()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

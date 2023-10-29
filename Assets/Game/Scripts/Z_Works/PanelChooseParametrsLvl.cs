using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelChooseParametrsLvl : MonoBehaviour, IAwakable
{
    private GameObject _gameObject;
    private AsyncOperation asyncOperation;

    private int test;

    public GameObject GameObject => _gameObject;

    public void Initialize()
    {
        _gameObject = gameObject;
    }

    public void LoadSceneAsync(int sceneIndex)
    {
        asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        asyncOperation.allowSceneActivation = false;
        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        SceneManager.UnloadSceneAsync(test);
        //asyncOperation.allowSceneActivation = true;
        //asyncOperation = SceneManager.UnloadSceneAsync(test);

        yield return null;
            //asyncOperation.allowSceneActivation = true;
            
    }
}

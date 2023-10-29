using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWinBehavior : MonoBehaviour, IBindable, IEnable
{
    private GameObject panelWin;
    private PoolEnemies poolEnemies;
    private WaveComponent waveComponent;

    private SaveLoadSystem saveLoadSystem;
    private MenuDatasBehavior menuDatasBehavior;

    private int indexNextScene;

    public void Bind()
    {
        poolEnemies = FindObjectOfType<PoolEnemies>();
        waveComponent = FindObjectOfType<WaveComponent>();

        PanelWinController panelWinController = FindObjectOfType<PanelWinController>(true);
        panelWin = panelWinController.gameObject;

        saveLoadSystem = FindAnyObjectByType<SaveLoadSystem>();
        menuDatasBehavior = FindObjectOfType<MenuDatasBehavior>();
        indexNextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void Enable()
    {
        waveComponent.onChangeWave.AddAction(Subscribe);
    }

    private void Subscribe()
    {
        if (waveComponent.Wave.Get < waveComponent.CountWave) return;
        InvokeRepeating(nameof(CheckWin), 2f, 1);
    }

    public void CheckWin()
    {
        for (int i = 0; i < poolEnemies.Enemies.Length; i++)
        {
            if (poolEnemies.Enemies[i].activeSelf) return;
        }
        
        panelWin.SetActive(true);
        CancelInvoke(nameof(CheckWin));
        menuDatasBehavior.SetCountOpenLvl(indexNextScene);
        saveLoadSystem.SaveLoadBehavior.SaveGame();
        GameTime.StopGame();
    }
}

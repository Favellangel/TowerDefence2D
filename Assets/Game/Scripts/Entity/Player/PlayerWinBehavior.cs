using UnityEngine;

public class PlayerWinBehavior : MonoBehaviour, IBindable, IEnable
{
    private GameObject panelWin;
    private WaveComponent waveComponent;
    private PoolEnemies poolEnemies;

    public void Bind()
    {
        waveComponent = FindObjectOfType<WaveComponent>();
        poolEnemies = FindObjectOfType<PoolEnemies>();

        PanelWinController panelWinController = FindObjectOfType<PanelWinController>(true);
        panelWin = panelWinController.gameObject;
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
        GameTime.StopGame();
    }
}

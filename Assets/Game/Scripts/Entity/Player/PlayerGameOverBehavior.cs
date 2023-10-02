using UnityEngine;

public class PlayerGameOverBehavior : MonoBehaviour, IAwakable, IBindable, IEnable
{
    private IEventable onDie;

    private GameObject panelGameOver;
    private PanelGameOverController gameOverController;

    public void Initialize()
    {
        onDie = GetComponent<HealthComponent>();
    }

    public void Bind()
    {
        gameOverController = FindObjectOfType<PanelGameOverController>(true);
        panelGameOver = gameOverController.gameObject;
    }

    public void Enable()
    {
        onDie.AddAction(GameOver);
    }

    private void OnDisable()
    {
        onDie.RemoveAction(GameOver);
    }

    private void OnDestroy()
    {
        onDie.RemoveAction(GameOver);
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0;
    }
}

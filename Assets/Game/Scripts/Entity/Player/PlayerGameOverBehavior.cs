using UnityEngine;

public class PlayerGameOverBehavior : Subscriber, IAwakable, IBindable
{
    private GameObject panelGameOver;

    public void Initialize()
    {
        onAction = GetComponent<HealthComponent>();
    }

    public void Bind()
    {
        PanelGameOverController gameOverController = FindObjectOfType<PanelGameOverController>(true);
        panelGameOver = gameOverController.gameObject;
    }

    public override void Execute()
    {
        panelGameOver.SetActive(true);
        GameTime.StopGame();
    }
}

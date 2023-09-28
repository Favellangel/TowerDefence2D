using UnityEngine;

public class PlayerGameOverBehavior : MonoBehaviour
{
    private IEventable onDie;

    private void Awake()
    {
        onDie = GetComponent<HealthComponent>();
    }

    private void OnEnable()
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
        Time.timeScale = 0;
        // отобразить меню поражения через пару сек
    }
}

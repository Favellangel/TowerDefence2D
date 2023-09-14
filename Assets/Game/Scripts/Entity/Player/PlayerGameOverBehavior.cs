using UnityEngine;

public class PlayerGameOverBehavior : MonoBehaviour
{
    public void GameOver()
    {
        Time.timeScale = 0;
        // отобразить меню поражения
    }
}

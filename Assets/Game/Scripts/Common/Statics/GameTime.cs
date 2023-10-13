using UnityEngine;

public static class GameTime 
{
    public static void StartGame()
    {
        Time.timeScale = 1.0f;
    }

    public static void StopGame()
    {
        Time.timeScale = 0.0f;
    }
}

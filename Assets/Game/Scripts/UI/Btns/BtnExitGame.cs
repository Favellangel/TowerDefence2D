using UnityEditor;
using UnityEngine;

public class BtnExitGame : BtnSubscriber
{
    protected override void Execute()
    {
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif

    }

}

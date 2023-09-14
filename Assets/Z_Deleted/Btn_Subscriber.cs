using UnityEngine;
using UnityEngine.UI;

public class Btn_Subscriber : MonoBehaviour
{
    private Button button;
    private IExecutable[] executables;

    private void Awake()
    {
        button = GetComponent<Button>();
        executables = GetComponents<IExecutable>();
    }

    private void OnEnable()
    {
        foreach (var item in executables)
        {
            button.onClick.AddListener(item.Execute);
        }
    }
}

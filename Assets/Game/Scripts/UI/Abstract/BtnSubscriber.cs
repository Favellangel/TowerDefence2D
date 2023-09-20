using UnityEngine;
using UnityEngine.UI;

public abstract class BtnSubscriber : MonoBehaviour
{
    protected Button btn;

    protected virtual void Awake()
    {
        btn = GetComponent<Button>();
    }

    protected virtual void OnEnable()
    {
        btn.onClick.AddListener(Execute);
    }

    protected virtual void OnDisable()
    {
        btn.onClick.RemoveListener(Execute);
    }

    protected virtual void OnDestroy()
    {
        btn.onClick.RemoveListener(Execute);
    }

    protected abstract void Execute();
}

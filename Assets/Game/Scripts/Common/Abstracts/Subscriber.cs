using UnityEngine;

public abstract class Subscriber : MonoBehaviour, IEnable
{
    protected IEventable onAction;

    public virtual void Enable()
    {
        onAction.AddAction(Execute);
    }

    private void OnEnable()
    {
        if (onAction == null) return;
        onAction.AddAction(Execute);
    }

    protected virtual void OnDisable()
    {
        if (onAction == null) return;
        onAction.RemoveAction(Execute);
    }

    protected virtual void OnDestroy()
    {
        if (onAction == null) return;
        onAction.RemoveAction(Execute);
    }

    public abstract void Execute();
}

using System;

public abstract class ActionAbstract
{
    protected Action OnChange;

    public void AddAction(Action action)
    {
        OnChange += action;
    }

    public void RemoveAction(Action action)
    {
        OnChange -= action;
    }
}

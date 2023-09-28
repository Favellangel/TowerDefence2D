using System;

public interface IEventable 
{
    protected Action OnChange { get; set; }

    public void AddAction(Action action)
    {
        OnChange += action;
    }

    public void RemoveAction(Action action)
    {
        OnChange -= action;
    }
}

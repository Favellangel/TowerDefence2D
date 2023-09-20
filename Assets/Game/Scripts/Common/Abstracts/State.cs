using System;

public abstract class State 
{
    protected Action<State> onChangeState;

    public void AddAction(Action<State> action)
    {
        onChangeState += action;
    }

    public void RemoveAction(Action<State> action)
    {
        onChangeState -= action;
    }

    public virtual void Enter() { }
    
    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void Exit() { }
}

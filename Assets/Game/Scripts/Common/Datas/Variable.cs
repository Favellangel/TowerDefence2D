using System;
using UnityEngine;

[Serializable]
public class Variable<T> : IGettable<T>, IEventable, IStringable
{
    [SerializeField] private T data;

    private Action onChange;

    Action IEventable.OnChange { get => onChange; set => onChange = value; }

    public T Get => data;

    public T Set
    {
        set
        {
            data = value;
            onChange?.Invoke();
        }
    }

    public string GetString()
    {
        return data.ToString();
    }
}

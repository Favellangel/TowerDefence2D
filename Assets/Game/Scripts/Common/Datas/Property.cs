using System;
using UnityEngine;

[Serializable]
public class Property<T> : ActionAbstract, IGettable<T> 
{
    [SerializeField] private T data;

    public T Get => data;

    public T Set
    {
        set
        {
            data = value;
            OnChange?.Invoke();
        }        
    }

    public override string ToString()
    {
        if(data == null ) 
            return string.Empty;
        else
            return data.ToString();
    }
}

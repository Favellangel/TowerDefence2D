using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntryPoint : MonoBehaviour
{
    private List<IBindable> bindList = new List<IBindable>();
    private List<IAwakable> initList = new List<IAwakable>();
    private List<IEnable> enebleList = new List<IEnable>();

    protected MonoBehaviour[] monoBehaviours;

    protected virtual void Awake()
    {
        GetLinks();
        
        foreach (var item in initList)
            item.Initialize();

        foreach (var item in bindList)
            item.Bind();
    }

    private void OnEnable()
    {
        foreach (var item in enebleList)
            item.Enable();
    }

    private void GetLinks()
    {
        IBindable bindable;
        IAwakable initializeble;
        IEnable enable;

        foreach (var monoBehaviour in monoBehaviours)
        {
            bindable = monoBehaviour as IBindable;
            enable = monoBehaviour as IEnable;
            initializeble = monoBehaviour as IAwakable;

            if(bindable != null)
                bindList.Add(bindable);

            if (enable != null)
                enebleList.Add(enable);

            if (initializeble != null)
                initList.Add(initializeble);

            bindable = null;
            enable = null;
            initializeble = null;
        }

        monoBehaviours = null;
        GC.Collect();
    }    
}

using System.Collections.Generic;
using UnityEngine;

public abstract class EntryPoint : MonoBehaviour
{
    private List<IAwakable> initList = new List<IAwakable>();
    private List<IEnable> enebleList = new List<IEnable>();

    protected MonoBehaviour[] monoBehaviours;

    protected virtual void Awake()
    {
        GetLinks();

        foreach (var item in initList)
            item.Initialize();
    }

    private void OnEnable()
    {
        foreach (var item in enebleList)
            item.Enable();
    }

    private void GetLinks()
    {
        IAwakable initializeble;
        IEnable enable;

        foreach (var monoBehaviour in monoBehaviours)
        {
            enable = monoBehaviour as IEnable;
            initializeble = monoBehaviour as IAwakable;

            if (enable != null)
                enebleList.Add(enable);

            if (initializeble != null)
                initList.Add(initializeble);
        }

        monoBehaviours = null;
    }    
}

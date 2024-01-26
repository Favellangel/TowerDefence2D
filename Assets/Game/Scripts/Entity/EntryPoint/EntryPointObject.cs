using System;
using UnityEngine;
using UnityEngine.UI;

public class EntryPointObject : EntryPoint
{
    protected override void Awake()
    {
        monoBehaviours = GetComponentsInChildren<MonoBehaviour>();
        base.Awake();
    }

}

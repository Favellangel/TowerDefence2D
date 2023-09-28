using System.Collections.Generic;
using UnityEngine;

public class EnemyUpdater : MonoBehaviour, IBindable
{
    private IUpdater[] updaters;
    private IFixedUpdater[] fixedUpdaters;

    public void Bind()
    {
        MonoBehaviour[] monoBehaviours = FindObjectsOfType<MonoBehaviour>(true);
        
        IUpdater updater;
        IFixedUpdater fixedUpdater;

        List<IUpdater> updatersTmp = new List<IUpdater>();
        List<IFixedUpdater> fixedUpdatersTmp = new List<IFixedUpdater>();

        foreach (var item in monoBehaviours)
        {
            updater = item as IUpdater;
            fixedUpdater = item as IFixedUpdater;

            if (updater != null)
                updatersTmp.Add(updater);

            if (fixedUpdater != null)
                fixedUpdatersTmp.Add(fixedUpdater);

            updater = null;
            fixedUpdater = null;
        }

        updaters = updatersTmp.ToArray();
        fixedUpdaters = fixedUpdatersTmp.ToArray();
    }

    private void Update()
    {
        for (int i = 0; i < updaters.Length; i++)
            updaters[i].UpdateMe();

    }

    private void FixedUpdate()
    {
        for (int i = 0; i < fixedUpdaters.Length; i++)
            fixedUpdaters[i].FixUpdate();
    }
}

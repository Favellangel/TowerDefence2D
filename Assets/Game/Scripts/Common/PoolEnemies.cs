using System.Collections.Generic;
using UnityEngine;

public class PoolEnemies : MonoBehaviour, IBindable
{    
    private GameObject[] enemies;

    public GameObject[] Enemies => enemies;

    public void Bind()
    {
        int count = 0;
        List<GameObject> list = new List<GameObject>();
        SpawnerComponent[] spawnerComponents = FindObjectsOfType<SpawnerComponent>();

        for (int i = 0; i < spawnerComponents.Length; i++)
        {
            count += spawnerComponents[i].Enemies.Length;
        }

        enemies = new GameObject[count];

        for (int i = 0; i < spawnerComponents.Length; i++)
        {
            list.AddRange(spawnerComponents[i].Enemies);
        }

        enemies = list.ToArray();
    }
}

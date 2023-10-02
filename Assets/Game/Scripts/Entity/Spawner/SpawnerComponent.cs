using System.Collections;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour, IAwakable
{
    [SerializeField] private float startDelay;
    [SerializeField] private int wave;

    [SerializeField] private UnitData unitData;
    [SerializeField] private Transform[] points;

    private WaveComponent waveComponent;

    private GameObject[] enemies;

    public int CountEnemy => enemies.Length;

    public void Initialize()
    {
        waveComponent = FindObjectOfType<WaveComponent>(true);
        enemies = new GameObject[unitData.count];
        CreateEnemies();
    }

    public void StartSpawn()
    {
        if (wave != waveComponent.Wave.Get) return;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startDelay);
       
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].SetActive(true);
            yield return new WaitForSeconds(unitData.delaySpawn);
        }
    }

    private void CreateEnemies()
    {
        for (int i = 0; i < unitData.count; i++)
        {
            GameObject enemy = Instantiate(unitData.prefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            enemy.hideFlags = HideFlags.HideInHierarchy;

            if (enemy.TryGetComponent(out EnemyMovement enemyMovement) == false) continue;
                
            enemyMovement.Initialize(points);
            enemies[i] = enemy;
        }
    }
}

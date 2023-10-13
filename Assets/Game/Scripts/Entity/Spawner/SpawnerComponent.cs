using UnityEngine;

public class SpawnerComponent : MonoBehaviour, IAwakable
{
    [SerializeField] private float startDelay;
    [SerializeField] private int wave;

    [SerializeField] private UnitData unitData;
    [SerializeField] private Transform[] points;

    private int i;

    private GameObject[] enemies;

    private WaveComponent waveComponent;

    public GameObject[] Enemies => enemies;

    public void Initialize()
    {
        if (gameObject.activeSelf == false) return;
        waveComponent = FindObjectOfType<WaveComponent>(true);
        enemies = new GameObject[unitData.count];
        CreateEnemies();
    }

    public void StartSpawn()
    {
        if (wave != waveComponent.Wave.Get) return;
        InvokeRepeating(nameof(ActivateEnemy), startDelay, unitData.delaySpawn);
    }

    private void ActivateEnemy()
    {
        if (i >= enemies.Length)
        {
            CancelInvoke(nameof(ActivateEnemy));
            i = 0;
            return;
        }

        enemies[i].SetActive(true);
        i++;
    }

    private void CreateEnemies()
    {
        for (int i = 0; i < unitData.count; i++)
        {
            GameObject enemy = Instantiate(unitData.prefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);

            if (enemy.TryGetComponent(out EnemyMovement enemyMovement) == false) continue;
                
            enemyMovement.GetPoints(points);
            enemies[i] = enemy;
        }
    }
}

using System.Collections;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour
{
    [SerializeField] private float startDelay;
    [SerializeField] private int wave;
    [SerializeField] private UnitData unitData;
    [SerializeField] private Transform[] points;

    private WaveComponent waveComponent;

    private void Awake()
    {
        waveComponent = FindObjectOfType<WaveComponent>(true);
    }

    public void StartSpawn()
    {
        if (wave != waveComponent.CurrentWave) return;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startDelay);

        for (int i = 0; i < unitData.count; i++)
        {
            GameObject enemy = Instantiate(unitData.prefab, transform.position, Quaternion.identity);

            if (enemy.TryGetComponent(out EnemyMovement enemyMovement))
                enemyMovement.Initialize(points);

            yield return new WaitForSeconds(unitData.delaySpawn);
        }
    }
}

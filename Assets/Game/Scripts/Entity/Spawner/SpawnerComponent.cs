using System.Collections;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour
{
    [SerializeField] private float startDelay;
    [SerializeField] private UnitData unitData;
    [SerializeField] private Transform[] points;

    public void SatrtSpawn()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startDelay);

        for (int i = 0; i < unitData.count; i++)
        {
            GameObject enemy = Instantiate(unitData.prefab, transform.position, Quaternion.identity);

            EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
            if (enemyMovement != null)
                enemyMovement.Initialize(points);

            yield return new WaitForSeconds(unitData.count);
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class FindTargetComponent : MonoBehaviour
{
    private List<GameObject> enemies = new List<GameObject>();

    public int Count => enemies.Count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.TryGetComponent(out EnemyMovement enemyMovement)) return;

        enemies.Add(collision.gameObject);
        //print(enemies.Count);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.TryGetComponent(out EnemyMovement enemyMovement)) return;

        enemies.Remove(collision.gameObject);
        //print(enemies.Count);
    }

    public GameObject GetTarget(int index)
    {
        return enemies[index];
    }
}

using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private int currentPoint;

    private Transform[] points;

    public void Initialize(Transform[] points)
    {
        this.points = points;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (points == null || points.Length == 0) return;

        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, Time.deltaTime * speed);

        if ((transform.position - points[currentPoint].position).magnitude > 0.01) return;

        currentPoint++;

        if (currentPoint > points.Length)
            currentPoint = 0;
    }
}

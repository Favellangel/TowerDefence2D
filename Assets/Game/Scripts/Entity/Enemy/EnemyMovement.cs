using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private int currentPoint;

    private Vector2 direction;

    private Rigidbody2D rb;
    private Transform[] points;

    public float Speed => speed;
    public Vector2 Direction => direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetPoints(Transform[] points)
    {
        this.points = points;
    }

    public void Move()
    {
        if (points == null || points.Length == 0) return;

        direction = points[currentPoint].position - transform.position;
        direction.Normalize();

        rb.MovePosition((Vector2)transform.position + direction * speed);

        ChooseNextPoint();
    }

    private void ChooseNextPoint()
    {
        if ((transform.position - points[currentPoint].position).magnitude > 0.01) return;

        currentPoint++;

        if (currentPoint > points.Length)
            currentPoint = 0;
    }
}

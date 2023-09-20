using System.Collections.Generic;
using UnityEngine;

public class ChechCollisionComponent : MonoBehaviour
{
    [SerializeField] private float collisionOffset;
    [SerializeField] private ContactFilter2D contactFilter;

    private Rigidbody2D rb;
    private Collider2D targetCollider;

    private List<RaycastHit2D> hits = new List<RaycastHit2D>();

    public Collider2D TargetCollider => targetCollider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public bool CheckCollision(Vector2 direction, float speed)
    {
        int count = rb.Cast(direction, contactFilter, hits, speed + collisionOffset);

        for (int i = 0; i < hits.Count; i++)
        {
            if (hits[i].collider.tag == "Barrier")
            {
                targetCollider = hits[i].collider;
                return true;
            }
        }

        return false;
    }

}

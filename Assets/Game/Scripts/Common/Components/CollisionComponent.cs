using System.Collections.Generic;
using UnityEngine;

public class CollisionComponent : MonoBehaviour
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

    public bool CheckCollision(Vector2 direction, float distance)
    {
        int count = rb.Cast(direction, contactFilter, hits, distance + collisionOffset);

        for (int i = 0; i < hits.Count; i++)
        {
            if (hits[i].collider.tag == Tags.barrier)
            {
                targetCollider = hits[i].collider;
                return true;
            }
        }

        return false;
    }
}

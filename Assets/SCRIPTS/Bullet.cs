using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void Update()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Skeleton")) // Tránh đạn va vào Skeleton
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform pointA, pointB;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;
    private int direction = 1; // 1 là sang phải, -1 là sang trái

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        targetPosition = pointB.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            Flip();
            Shoot();
            targetPosition = (targetPosition == pointA.position) ? pointB.position : pointA.position;
        }
    }

    void Flip()
    {
        direction *= -1;
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.SetDirection(new Vector2(direction, 0)); // Đạn bay theo hướng Skeleton đang nhìn
            }
            Destroy(bullet, 3f);
        }
    }
}

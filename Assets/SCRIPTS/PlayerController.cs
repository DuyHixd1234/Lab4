using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Animator animator;
    private Vector2 movement;
    private int waterAmount = 1; // Số lượng nước người chơi có

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Lấy input từ bàn phím
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Kiểm tra nhân vật có di chuyển không
        bool isMoving = movement.sqrMagnitude > 0;

        // Gán giá trị cho Animator
        animator.SetBool("isMoving", isMoving);

        // Di chuyển nhân vật
        transform.position += new Vector3(movement.x, movement.y, 0) * speed * Time.deltaTime;

        // Lật hình khi di chuyển trái/phải
        if (movement.x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(movement.x), 1, 1);
        }
    }

    // Kiểm tra nhân vật có nước không
    public bool HasWater()
    {
        return waterAmount > 0;
    }

    // Sử dụng nước
    public void UseWater()
    {
        if (HasWater())
        {
            waterAmount--;
            Debug.Log("Đã tưới nước, nước còn lại: " + waterAmount);
        }
    }

    // Hứng nước từ suối hoặc giếng
    public void CollectWater()
    {
        waterAmount++;
        Debug.Log("Đã lấy nước, nước hiện tại: " + waterAmount);
    }
}

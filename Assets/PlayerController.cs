using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Trap"))
        {
            Destroy(gameObject);
        }
    }

}


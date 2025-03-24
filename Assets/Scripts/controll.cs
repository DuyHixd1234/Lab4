using UnityEngine;

public class controll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabCircle;
    public GameObject prefabTriangle;
    public GameObject prefabSquare;
    void Start()
    {
        Vector2 pos = new Vector2(-2.0f, 0.0f);
        GameObject a = Instantiate(prefabCircle, pos, Quaternion.identity);
        Rigidbody2D rg = a.GetComponent<Rigidbody2D>();
        rg.linearVelocity = Vector2.one;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 pos = new Vector2(1f, 1.0f);
            GameObject a = Instantiate(prefabCircle, pos, Quaternion.identity);
            Destroy(a, 4);
        }    
    }
}

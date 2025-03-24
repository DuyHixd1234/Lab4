using UnityEngine;
using UnityEngine.LowLevelPhysics;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject triangle;

    void Start()
    {
        triangle = GameObject.FindWithTag("Player");
        Transform haha = triangle.transform;
        haha.position = Vector2.zero;
        Rigidbody2D rb = haha.GetComponent<Rigidbody2D>();
        rb.mass = 10.0f;
        Destroy(triangle, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

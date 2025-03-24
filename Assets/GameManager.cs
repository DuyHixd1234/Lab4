using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rotatingObject;
    public float rotationSpeed = 50f;

    public GameObject gameObjectA;
    public GameObject gameObjectB; 
    public float turnSpeed = 100f; 

    void Update()
    {

        if (rotatingObject)
        {
            rotatingObject.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

       
        if (gameObjectA && gameObjectB)
        {
            RotateToward();
        }
    }

    void RotateToward()
    {
        Vector3 direction = gameObjectB.transform.position - gameObjectA.transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);

        gameObjectA.transform.rotation = Quaternion.RotateTowards(
            gameObjectA.transform.rotation,
            targetRotation,
            turnSpeed * Time.deltaTime
        );
    }
}

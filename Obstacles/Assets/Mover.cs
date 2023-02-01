using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] face ca variabila sa poata fi vizibila in Unity
    // [SerializeField] private float yValue = 0.02f;
    [SerializeField] private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // X,Y,Z -> add 1 to X, 0 to Y and 0 to Z axes
        // transform.Translate(1,0,0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void Movement() 
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(xValue,0,zValue);
    }
}

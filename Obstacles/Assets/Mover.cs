using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] face ca variabila sa poata fi vizibila in Unity
    // [SerializeField] private float yValue = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        // X,Y,Z -> add 1 to X, 0 to Y and 0 to Z axes
        // transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue,0,zValue);
    }
}

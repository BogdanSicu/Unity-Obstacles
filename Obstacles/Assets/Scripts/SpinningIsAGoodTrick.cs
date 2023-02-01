using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningIsAGoodTrick : MonoBehaviour
{
    [SerializeField] private float xValue = 0f;
    [SerializeField] private float yValue = 0f;
    [SerializeField] private float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}

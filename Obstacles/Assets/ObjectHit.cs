using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Collision other este obiectul care se loveste de cel care are atasat scriptul
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("You hit the wall");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}

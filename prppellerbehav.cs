using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prppellerbehav : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float rotatespeed =10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward*Time.deltaTime*rotatespeed);
    }
}

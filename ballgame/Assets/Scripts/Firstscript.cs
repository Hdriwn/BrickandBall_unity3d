using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    public Rigidbody rb;

    void Start()
    {
     print("start");  
     rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}

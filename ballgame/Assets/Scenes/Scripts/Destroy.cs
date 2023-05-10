using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        //Unity collision Reference: https://docs.unity3d.com/ScriptReference/Collision.html
        // foreach loop to iterate through the contact points of the collision
        Destroy (gameObject);
    }
}

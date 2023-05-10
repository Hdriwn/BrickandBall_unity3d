
using UnityEngine;
using System.Collections;
public class Paddle_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            transform.Translate(10f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        //Unity collision Reference: https://docs.unity3d.com/ScriptReference/Collision.html
        // foreach loop to iterate through the contact points of the collision
        foreach(ContactPoint contact in collision.contacts)
        {
            
            if( contact.thisCollider==GetComponent<Collider>()){
                // Calculating the english of the ball, which is the x coordinate of the contact point wrt the paddle
                float english = contact.point.x-transform.position.x;
                // here the force is applied to the ball, which is the other collider
                contact.otherCollider.GetComponent<Rigidbody>().AddForce(200f*english, 0, 0);
            }
        }
    }
}   

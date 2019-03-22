using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 3.5f;
    public float jumpForce = 10f;

    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dead == true)
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            return;
        }
        //Move forward
        GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y, speed);

        //Make bird jump
        if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space")) {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpForce, GetComponent<Rigidbody>().velocity.z);

        }
    
        
    }

     void OnTriggerEnter (Collider otherCollider)
    {
     if (otherCollider.tag =="Obstacle")
        {
            dead = true;
        }

    }
    
        
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject leftObject;
    public GameObject rightObject;

    public int moveSpeed = 30;
    public int maxSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Key presses and movement
        if (Input.GetKey(GlobalScript.right)
            && leftObject.GetComponent<Rigidbody2D>().velocity.x <= maxSpeed
            && rightObject.GetComponent<Rigidbody2D>().velocity.x >= -maxSpeed)
        {
            leftObject.GetComponent<Rigidbody2D>().velocity += Vector2.right * moveSpeed;
            rightObject.GetComponent<Rigidbody2D>().velocity -= Vector2.right * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.left)
            && leftObject.GetComponent<Rigidbody2D>().velocity.x >= -maxSpeed
            && rightObject.GetComponent<Rigidbody2D>().velocity.x <= maxSpeed)
        {
            leftObject.GetComponent<Rigidbody2D>().velocity += Vector2.left * moveSpeed;
            rightObject.GetComponent<Rigidbody2D>().velocity -= Vector2.left * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.up)
            && leftObject.GetComponent<Rigidbody2D>().velocity.y >= -maxSpeed
            && rightObject.GetComponent<Rigidbody2D>().velocity.y <= maxSpeed)
        {
            leftObject.GetComponent<Rigidbody2D>().velocity -= Vector2.up * moveSpeed;
            rightObject.GetComponent<Rigidbody2D>().velocity += Vector2.up * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.down)
            && leftObject.GetComponent<Rigidbody2D>().velocity.y <= maxSpeed
            && rightObject.GetComponent<Rigidbody2D>().velocity.y >= -maxSpeed)
        {
            leftObject.GetComponent<Rigidbody2D>().velocity -= Vector2.down * moveSpeed;
            rightObject.GetComponent<Rigidbody2D>().velocity += Vector2.down * moveSpeed;
        }
    }

    void Update()
    {
        // Stop movement when release key
        if (Input.GetKeyUp(GlobalScript.right))
        {
            leftObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rightObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.left))
        {
            leftObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rightObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.up))
        {
            leftObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rightObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.down))
        {
            leftObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rightObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject leftObject;
    public GameObject rightObject;

    public int moveSpeed = 30;
    public int maxSpeed = 10;

    private SpriteRenderer _wipe;
    private CircleCollider2D _center;

    private Rigidbody2D _leftRigidbody;
    private Rigidbody2D _rightRigidbody;

    private BoxCollider2D _leftCollider;
    private BoxCollider2D _rightCollider;

    public float wipeSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _wipe = this.GetComponent<SpriteRenderer>();
        _center = this.GetComponent<CircleCollider2D>();

        _leftRigidbody = leftObject.GetComponent<Rigidbody2D>();
        _rightRigidbody = rightObject.GetComponent<Rigidbody2D>();

        _leftCollider = leftObject.GetComponent<BoxCollider2D>();
        _rightCollider = rightObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Key presses and movement
        if (Input.GetKey(GlobalScript.right)
            && _leftRigidbody.velocity.x <= maxSpeed
            && _rightRigidbody.velocity.x >= -maxSpeed)
        {
            _leftRigidbody.velocity += Vector2.right * moveSpeed;
            _rightRigidbody.velocity -= Vector2.right * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.left)
            && _leftRigidbody.velocity.x >= -maxSpeed
            && _rightRigidbody.velocity.x <= maxSpeed)
        {
            _leftRigidbody.velocity += Vector2.left * moveSpeed;
            _rightRigidbody.velocity -= Vector2.left * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.up)
            && _leftRigidbody.velocity.y >= -maxSpeed
            && _rightRigidbody.velocity.y <= maxSpeed)
        {
            _leftRigidbody.velocity -= Vector2.up * moveSpeed;
            _rightRigidbody.velocity += Vector2.up * moveSpeed;
        }

        if (Input.GetKey(GlobalScript.down)
            && _leftRigidbody.velocity.y <= maxSpeed
            && _rightRigidbody.velocity.y >= -maxSpeed)
        {
            _leftRigidbody.velocity -= Vector2.down * moveSpeed;
            _rightRigidbody.velocity += Vector2.down * moveSpeed;
        }
    }

    void Update()
    {
        // Stop movement when release key
        if (Input.GetKeyUp(GlobalScript.right))
        {
            _leftRigidbody.velocity = Vector2.zero;
            _rightRigidbody.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.left))
        {
            _leftRigidbody.velocity = Vector2.zero;
            _rightRigidbody.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.up))
        {
            _leftRigidbody.velocity = Vector2.zero;
            _rightRigidbody.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(GlobalScript.down))
        {
            _leftRigidbody.velocity = Vector2.zero;
            _rightRigidbody.velocity = Vector2.zero;
        }

        //Mission Success
        if (_center.IsTouching(_leftCollider) 
            && _center.IsTouching(_rightCollider))
        {
            Time.timeScale = 0;
            _wipe.enabled = true;
        }

        if (_wipe.enabled)
        {
            _wipe.size += (new Vector2(1, 1) * wipeSpeed) * Time.deltaTime;
        }
    }
}

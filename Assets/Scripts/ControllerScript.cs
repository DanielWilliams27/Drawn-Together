using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject leftObject;
    public GameObject rightObject;

    public int moveSpeed = 30;

    private SpriteRenderer _wipe;
    private CircleCollider2D _center;

    private Rigidbody2D _leftRigidbody;
    private Rigidbody2D _rightRigidbody;

    private BoxCollider2D _leftCollider;
    private BoxCollider2D _rightCollider;

    public float wipeSpeed = 0.5f;
    public float maxWipe = 110f;

    public static bool playState = true;

    public GameObject success;
    public GameObject failed;

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
        if (Input.GetKey(GlobalScript.right))
        {
            if (playState)
            {
                _leftRigidbody.velocity += (Vector2.right * moveSpeed) * Time.deltaTime;
                _rightRigidbody.velocity -= (Vector2.right * moveSpeed) * Time.deltaTime;
            }
            else
            {
                _leftRigidbody.velocity = Vector2.zero;
                _rightRigidbody.velocity = Vector2.zero;
            }
        }

        if (Input.GetKey(GlobalScript.left))
        {
            if (playState)
            {
                _leftRigidbody.velocity += (Vector2.left * moveSpeed) * Time.deltaTime;
                _rightRigidbody.velocity -= (Vector2.left * moveSpeed) * Time.deltaTime;
            }
            else
            {
                _leftRigidbody.velocity = Vector2.zero;
                _rightRigidbody.velocity = Vector2.zero;
            }
        }

        if (Input.GetKey(GlobalScript.up))
        {
            if (playState)
            {
                _leftRigidbody.velocity -= (Vector2.up * moveSpeed) * Time.deltaTime;
                _rightRigidbody.velocity += (Vector2.up * moveSpeed) * Time.deltaTime;
            }
            else
            {
                _leftRigidbody.velocity = Vector2.zero;
                _rightRigidbody.velocity = Vector2.zero;
            }
        }

        if (Input.GetKey(GlobalScript.down))
        {
            if (playState)
            {
                _leftRigidbody.velocity -= (Vector2.down * moveSpeed) * Time.deltaTime;
                _rightRigidbody.velocity += (Vector2.down * moveSpeed) * Time.deltaTime;
            }
            else
            {
                _leftRigidbody.velocity = Vector2.zero;
                _rightRigidbody.velocity = Vector2.zero;
            }
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

        // Level Success
        if (_center.IsTouching(_leftCollider) 
            && _center.IsTouching(_rightCollider))
        {
            LevelOver(success);
            
        }

        // Level Failed
        if (_leftRigidbody.IsTouchingLayers()
            || _rightRigidbody.IsTouchingLayers()
            && !_center.IsTouching(_leftCollider)
            && !_center.IsTouching(_rightCollider))
        {
            LevelOver(failed);
        }

        if (_wipe.enabled && _wipe.size.x <= CameraScript.cameraSize * 3)
        {
            _wipe.size += (new Vector2(1, 1) * wipeSpeed) * Time.deltaTime;
        }
    }

    private void LevelOver(GameObject overScreen)
    {
        playState = false;
        _wipe.enabled = true;
        if (_wipe.size.x >= CameraScript.cameraSize * 3)
        {
            overScreen.SetActive(true);
        }
    }
}

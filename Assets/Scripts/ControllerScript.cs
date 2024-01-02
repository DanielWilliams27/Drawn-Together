using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject leftObject;
    public GameObject rightObject;

    public int moveSpeed = 30;

    public static SpriteRenderer wipe;
    public static CircleCollider2D center;

    private Rigidbody2D _leftRigidbody;
    private Rigidbody2D _rightRigidbody;

    public static BoxCollider2D leftCollider;
    public static BoxCollider2D rightCollider;

    public float wipeSpeed = 0.5f;
    public float maxWipe = 110f;

    public static bool playState = true;

    public GameObject success;
    public GameObject failed;

    public static bool overScreen;

    // Start is called before the first frame update
    void Start()
    {
        wipe = this.GetComponent<SpriteRenderer>();
        center = this.GetComponent<CircleCollider2D>();

        _leftRigidbody = leftObject.GetComponent<Rigidbody2D>();
        _rightRigidbody = rightObject.GetComponent<Rigidbody2D>();

        leftCollider = leftObject.GetComponent<BoxCollider2D>();
        rightCollider = rightObject.GetComponent<BoxCollider2D>();
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

        /*// Level Cleared
        if (center.IsTouching(leftCollider) 
            && center.IsTouching(rightCollider))
        {
            LevelOver();
            overScreen = true;
        } 
        else if (_leftRigidbody.IsTouchingLayers()
            || _rightRigidbody.IsTouchingLayers())  //Level Failed
        {
            LevelOver();
            overScreen = false;
        }*/

        if (wipe.enabled && wipe.size.x <= CameraScript.cameraSize * 3)
        {
            wipe.size += (new Vector2(1, 1) * wipeSpeed) * Time.deltaTime;

            if (wipe.size.x >= (CameraScript.cameraSize * 2))
            {
                if (overScreen)
                {
                    success.SetActive(true);
                }
                else
                {
                    failed.SetActive(true);
                }
            }
        }
    }

    public static void LevelOver()
    {
        playState = false;
        wipe.enabled = true;
    }
}

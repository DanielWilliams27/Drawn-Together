using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public Sprite baseSprite, selectedSprite;
    private bool _selected = false;
    public GameObject obstacle;

    private float _baseXPosition, _baseYPosition, _baseRotation, _baseXScale, _baseYScale;
    public float newXPosition, newYPosition, newRotation, newXScale, newYScale;

    public float moveSpeed = 5f;

    private Vector3 _basePosition, _newPosition, _baseRotate, _newRotate, _baseScale, _newScale;
    
    // Start is called before the first frame update
    void Start()
    {
        _baseXPosition = obstacle.transform.position.x;
        _baseYPosition = obstacle.transform.position.y;
        _baseRotation = obstacle.transform.rotation.z;
        _baseXScale = obstacle.transform.lossyScale.x;
        _baseYScale = obstacle.transform.lossyScale.y;

        _basePosition = new Vector3(_baseXPosition, _baseYPosition, 0);
        _newPosition = new Vector3(newXPosition, newYPosition, 0);
        _baseRotate = new Vector3(0, 0, _baseRotation);
        _newRotate = new Vector3(0, 0, newRotation);
        _baseScale = new Vector3(_baseXScale, _baseYScale, 0);
        _newScale = new Vector3(newXScale, newYScale, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selected)
        {
            obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, _newPosition, moveSpeed * Time.deltaTime);
            obstacle.transform.Rotate(_newRotate);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_selected)
        {
            _selected = false;
        }
        else
        {
            _selected = true;
        }
    }
}

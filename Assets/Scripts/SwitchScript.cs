using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public Sprite baseSprite, selectedSprite;
    private bool _selected = false;
    public GameObject obstacle;

    private float _baseXPosition, _baseYPosition;
    public float newXPosition, newYPosition;

    public float moveSpeed = 5f;

    private Vector3 _basePosition, _newPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _baseXPosition = obstacle.transform.position.x;
        _baseYPosition = obstacle.transform.position.y;

        _basePosition = new Vector3(_baseXPosition, _baseYPosition, 0);
        _newPosition = new Vector3(newXPosition, newYPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selected && obstacle.transform.position != _newPosition)
        {
            obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, _newPosition, moveSpeed * Time.deltaTime);
        }

        if (!_selected && obstacle.transform.position != _basePosition)
        {
            obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, _basePosition, moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_selected)
            {
                _selected = false;
                _spriteRenderer.sprite = baseSprite;
            }
            else
            {
                _selected = true;
                _spriteRenderer.sprite = selectedSprite;
            }
        }
    }
}

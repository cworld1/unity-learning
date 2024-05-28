using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class D14PlayerController : MonoBehaviour
{
    [SerializeField] GameObject _light;
    // Our components
    Rigidbody2D _rb; // create the container for out rigidbody2d

    // Our fields related to movement
    float _moveHorizontal; // get horizontal input
    float _moveSpeed = 10f; // our movespeed
    Vector2 _currentVelocity; // our current velocity;

    // Trigger example
    bool _canInteract = false;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the rigidbody to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Assign the current speed/velocity
        _currentVelocity = new Vector2(_moveHorizontal, 0f) * _moveSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && _canInteract)
        {
            _light.SetActive(!_light.activeSelf);
            Debug.Log("Light is " + (_light.activeSelf ? "on" : "off"));
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Enter: " + other.gameObject.name);
            // other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Exit: " + other.gameObject.name);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Light"))
        {
            Debug.Log("You've reached the light!");
            _canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Light"))
        {
            Debug.Log("You've leaved the light!");
            _canInteract = false;
        }
    }

    // Create the method for player movement
    void MovePlayer()
    {
        if (_moveHorizontal == 0) // check for player input
        {
            // If standing still, set player movement to zero
            _currentVelocity = new Vector2(0f, 0f);
        }
        _rb.velocity = _currentVelocity; // Set the player movement to the current velocity
    }
}

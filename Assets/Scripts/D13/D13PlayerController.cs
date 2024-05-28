using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D13PlayerController : MonoBehaviour
{
    // Move using RigidBody
    Rigidbody2D _rb;
    float _inputHorizontal;
    float _moveSpeed = 10f;
    Vector2 _currentVelocity;

    // Move using transform
    float _moveSpeedTransform = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Move using RigidBody
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move using RigidBody
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _currentVelocity = new Vector2(_inputHorizontal * _moveSpeed, 0f);

        // MovePlayerTransform();
    }

    void FixedUpdate()
    {
        // If you use rigidBody to update, it is important
        // to separate your updating position code
        // as keyboard thing in update function,
        // and update position in fixedupdate function.
        MovePlayerRigidBody();
    }

    void MovePlayerTransform()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector2(-_moveSpeedTransform * Time.deltaTime, 0f), Space.Self);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector2(_moveSpeedTransform * Time.deltaTime, 0f), Space.Self);
        }
    }

    void MovePlayerRigidBody()
    {
        if (_inputHorizontal != 0)
        {
            _rb.velocity = _currentVelocity;
        }
        else
        {
            _currentVelocity = new Vector2(0f, 0f);
            _rb.velocity = _currentVelocity;
        }
    }
}

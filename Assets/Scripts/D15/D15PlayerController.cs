using System;
using System.Numerics;
using UnityEngine;

public class D15PlayerController : MonoBehaviour
{
    public bool _disableMovement = false;

    // Our components
    Rigidbody2D _rb;

    // Our fields related to components
    float _moveHorizontal; // Get horizontal input
    float _moveSpeed = 60f; // Out movespeed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign the RigidBody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if (!_disableMovement)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        if (_moveHorizontal != 0) // check fot player input
        {
            _rb.AddForce(new UnityEngine.Vector2(_moveHorizontal * _moveSpeed, 0f));
        }
    }
}

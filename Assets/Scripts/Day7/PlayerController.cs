using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehaviour _objectBehaviour;

    float _playerSpeed = 10f;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehaviour.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0));
        }
    }
}

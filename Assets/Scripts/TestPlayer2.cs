using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer2 : MonoBehaviour
{
    private Rigidbody2D _rb;

    private int _playerHealth = 100;
    // private is default
    // int _playerHealth;
    [SerializeField] private float _playerSpeed = 4.6f;
    // by this field you can update it in the unity or even other scripts!
    // maybe public defines can also, but it is not secure or standard
    private bool _isGrounded = true;
    private string _playerName = "CWorld";
    // private Vector3 _playerPosition = new Vector3(-5f, 0f, 0f);
    // for 2d game you can
    private Vector2 _playerPosition = new Vector2(-5f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.transform.position = _playerPosition;
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System;
using System.Collections;
using UnityEngine;

public class D17PlayerController : MonoBehaviour
{
    [SerializeField] D17GameManager _gameManager;
    Rigidbody2D _rb;
    Camera _mainCamera;

    // Self state
    float _moveVertical;
    float _moveHorizontal;
    float _moveSpeed = 5f;
    float _speedLimiter = 0.7f;
    Vector2 _moveVelocity;

    // Mouse manage state
    Vector2 _mousePos;
    Vector2 _offset;

    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _bulletSpawn;

    bool _isShooting = false;
    float _bulletSpeed = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input movement
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        _moveVertical = Input.GetAxisRaw("Vertical");
        _moveVelocity = new Vector2(_moveHorizontal, _moveVertical) * _moveSpeed;

        // Get mouse bullet action
        if (Input.GetMouseButtonDown(0))
        {
            _isShooting = true;
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();

        if (_isShooting)
        {
            StartCoroutine(Fire());
        }
    }

    void MovePlayer()
    {
        if (_moveHorizontal != 0 || _moveVertical != 0)
        {
            if (_moveHorizontal != 0 && _moveVertical != 0)
            {
                _moveVelocity *= _speedLimiter;
            }
            _rb.velocity = _moveVelocity;
        }
        else
        {
            _moveVelocity = new Vector2(0f, 0f);
            _rb.velocity = _moveVelocity;
        }
    }

    void RotatePlayer()
    {
        // Get mouse direction & distance to the player
        _mousePos = Input.mousePosition;
        Vector3 screenPoint = _mainCamera.WorldToScreenPoint(gameObject.transform.localPosition);
        _offset = new Vector2(_mousePos.x - screenPoint.x, _mousePos.y - screenPoint.y).normalized;
        // Debug.Log(_offset);

        float angle = Mathf.Atan2(_offset.y, _offset.x) * Mathf.Rad2Deg;

        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
        // Minusing the 90f degress to ensure the head towards you, but not the x axis
    }

    IEnumerator Fire()
    {
        _isShooting = false;
        GameObject bullet = Instantiate(_bullet, _bulletSpawn.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = _offset * _bulletSpeed;

        yield return new WaitForSeconds(3);
        Destroy(bullet);
    }
}

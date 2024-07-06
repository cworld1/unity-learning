using UnityEngine;

public class D17EnemyBehaviour : MonoBehaviour
{
    // [SerializeField] D17GameManager _gameManager;
    D17GameManager _gameManager;
    GameObject _player;

    float _enemytHealth = 100f;
    float _enemyMoveSpeed = 2f;
    Quaternion _targetRotation;
    bool _disableEnemy = false;
    Vector2 _moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // The slowest way to get
        _gameManager = GameObject.Find("GameManager").GetComponent<D17GameManager>();
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!_gameManager._gameOver || !_disableEnemy)
        {
            MoveEnemy();
            RotateEnemy();
        }
    }

    void MoveEnemy()
    {
        gameObject.transform.position = Vector2.MoveTowards(
            gameObject.transform.position, _player.transform.position,
            _enemyMoveSpeed * Time.deltaTime);
    }

    void RotateEnemy()
    {
        _moveDirection = gameObject.transform.position - _player.transform.position;
        _moveDirection.Normalize();

        // Calculate the rotation
        _targetRotation = Quaternion.LookRotation(Vector3.forward, _moveDirection);

        if (gameObject.transform.rotation != _targetRotation)
        {
            gameObject.transform.rotation = Quaternion.RotateTowards(
                gameObject.transform.rotation, _targetRotation, 200 * Time.deltaTime);
        }
    }

}

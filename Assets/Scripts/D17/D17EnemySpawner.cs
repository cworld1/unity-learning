using System.Collections;
using UnityEngine;

public class D17EnemySpawner : MonoBehaviour
{
    [SerializeField] D17GameManager _gameManager;
    [SerializeField] GameObject[] _spawnPoints;
    [SerializeField] GameObject _enemy;
    float _spawnTimer = 2f;
    float _spawnRateIncrease = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnNextEnemy());
        StartCoroutine(SpawnRateIncrease());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnNextEnemy()
    {
        // Random get location and generate it
        int nextSpawnLocation = Random.Range(0, _spawnPoints.Length);
        Instantiate(_enemy, _spawnPoints[nextSpawnLocation].transform.position, Quaternion.identity);

        // Wait and generate another
        yield return new WaitForSeconds(_spawnTimer);
        if (!_gameManager._gameOver)
        {
            StartCoroutine(SpawnNextEnemy());
        }
    }
    IEnumerator SpawnRateIncrease()
    {
        yield return new WaitForSeconds(_spawnRateIncrease);

        if (_spawnTimer >= 0.5f)
        {
            _spawnTimer -= 0.2f;
        }

        StartCoroutine(SpawnRateIncrease());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    bool _gameOver = false;

    public void SpawnObject()
    {
        Instantiate(
            prefab,
            new Vector3(Random.Range(-8f, 8f), 6f, 0f),
            Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            SpawnObject();
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Ground")
        {
            _gameOver = true;
            Debug.Log("GAME OVER! You lose!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Example 1
    // int _number = 12;
    int[] _numberArray = new int[4];

    // Example 2
    // string[] _names = new string[3];
    string[] _names = { "Frida", "Basse", "Bella" };

    // Example 2
    // public GameObject[] _players;
    [SerializeField] GameObject[] _players;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _numberArray[0] = 10;
        _numberArray[1] = 23;
        _numberArray[2] = 53;
        _numberArray[3] = 15;

        // Debug.Log(_numberArray[0]);
        _players = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _players = GameObject.FindGameObjectsWithTag("Enemy");
        }
    }
}

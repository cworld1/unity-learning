using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day4Player : MonoBehaviour
{
    private int _playerHealth = 100;
    // a easier way to declare getter & setter
    public int PlayerSpeed { get; set; }

    // get & set method define
    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }

        // if no setter, the set action is not allowed
        set
        {
            if (value > 100)
            {
                Debug.Log("Over the maximum value detected.");
                return;
            };
            _playerHealth = value;
        }
    }

    public string DisplayHealthPercentage
    {
        get
        {
            string health = _playerHealth.ToString() + "%";
            return health;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth += 50;
        Debug.Log(DisplayHealthPercentage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

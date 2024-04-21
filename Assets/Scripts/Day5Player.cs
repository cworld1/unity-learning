using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5Player : MonoBehaviour
{
    private int _playerHealth = 100;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }

        set
        {
            _playerHealth = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // wrong that don't return data
        // Debug.Log(TakeDamege());
        Debug.Log(ShowDamage());

        // but you can
        // TakeDamege);
        // even with a num
        TakeDamege(50);
        Debug.Log(PlayerHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // private void TakeDamege()
    void TakeDamege(int dagame)
    {
        PlayerHealth -= dagame;
    }

    int ShowDamage()
    {
        PlayerHealth -= 10;
        return PlayerHealth;
    }
}

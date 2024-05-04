using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Day6Player : MonoBehaviour
{
    private int _playerHealth = 100;
    private int _playerSheild = 50;

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

    public int PlayerSheild
    {
        get
        {
            return _playerSheild;
        }

        set
        {
            _playerSheild = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enemy make 30 damage. You took " + DamageTaken(30) + " in damage!");
        Debug.Log("Enemy make 50 damage. You took " + DamageTaken(50) + " in damage!");
        Debug.Log("Enemy make 70 damage. You took " + DamageTaken(70) + " in damage!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // calculate the status of sheild & damage taken
    int DamageTaken(int damage)
    {
        int damageTaken;

        if (damage < PlayerSheild)
        {
            Debug.Log("Sheild not destroyed!");
            damageTaken = 0;
        }
        else if (damage == PlayerSheild)
        {
            Debug.Log("Sheild destroyed!");
            damageTaken = 0;
        }
        else
        {
            Debug.Log("Sheild destroyed and damage taken!");
            damageTaken = damage - PlayerSheild;
        }
        // other comparation: >=, !=, <=
        // and pipes: && ||
        // and brankets: ()

        return damageTaken;
    }
}

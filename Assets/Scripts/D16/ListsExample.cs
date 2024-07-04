using System.Collections.Generic;
using UnityEngine;

public class ListsExample : MonoBehaviour
{
    // List<int> _numbers = new List<int>();
    List<string> _numbers = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _numbers.Add("Daniel");
        _numbers.Add("Frida");
        _numbers.Add("Basse");
        _numbers.Add("Bella");

        _numbers.Remove("Daniel");
        _numbers.Insert(1, "Oliver");

        _numbers.ForEach(delegate (string s)
        {
            Debug.Log(s);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}

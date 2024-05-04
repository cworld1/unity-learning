using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript02 : MonoBehaviour
{
    [SerializeField] GameObject _squareParent;
    [SerializeField] GameObject _square;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("State change " + _squareParent.activeSelf + " to " + !_squareParent.activeSelf);
            _squareParent.SetActive(!_squareParent.activeSelf);
            Debug.Log("Child state origin is " + _square.activeSelf + " but actually is " + _square.activeInHierarchy);
        }
    }
}

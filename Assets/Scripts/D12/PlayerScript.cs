using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float _moveSpeed = 10f;
    float _rotateSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed) * Time.deltaTime, Space.Self);
            // gameObject can be omitted
            // transform.Translate(...);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, -_moveSpeed) * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotateSpeed) * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }
    }
}

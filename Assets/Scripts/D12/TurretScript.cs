using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector2 lasrRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.LookAt(target);
        // it is a 3d components sulution, but for 2d, it looks a little weird.
        Vector2 direction = target.position - transform.position;
        if (lasrRotation != direction)
        {
            // transform.rotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), direction);
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
            Debug.Log(transform.rotation);
        }
        lasrRotation = direction;
    }
}

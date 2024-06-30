using System.Collections;
using UnityEngine;

public class PlayerTelePort : MonoBehaviour
{
    D15PlayerController _playerController;
    [SerializeField] GameObject _teleportLocation;
    Coroutine _coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerController = gameObject.GetComponent<D15PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _coroutine = StartCoroutine(TeleportDelay());
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            StopCoroutine(_coroutine);
            _playerController._disableMovement = false;
        }
    }

    IEnumerator TeleportDelay()
    {
        _playerController._disableMovement = true;
        yield return new WaitForSeconds(1.5f);
        gameObject.transform.position = _teleportLocation.transform.position;
        yield return null;
        _playerController._disableMovement = false;
    }
}

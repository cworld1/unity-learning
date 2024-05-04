using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day8GMScript : MonoBehaviour
{
    [SerializeField] GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        int itemCount = 0;

        // while statement will check instantly
        while (itemCount < 4)
        {
            SpawnItem(HexToColor("#948979"));
            itemCount++;
        }

        // do statement will force running at least once
        // do
        // {
        //     SpawnItem();
        //     itemCount--;
        // }
        // while (itemCount > 0);

        // for is better for counter
        for (int i = 0; i < 4; i++)
            SpawnItem(HexToColor("#DFD0B8"));

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnItem(Color color)
    {
        GameObject newItem = Instantiate(_item, new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-3.5f, 3.5f)), Quaternion.identity);
        newItem.GetComponent<Renderer>().material.color = color;
    }

    Color HexToColor(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color); // Convert hexadecimal color strings to Color type
        return color;
    }
}

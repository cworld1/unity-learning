using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
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
        Color color = Color.white;
        ColorUtility.TryParseHtmlString(hex, out color); // 将十六进制颜色字符串转换为 Color 类型
        return color;
    }
}

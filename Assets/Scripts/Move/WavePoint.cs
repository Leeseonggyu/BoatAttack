using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePoint : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos= gameObject.transform.position;
        float theta = startPos.x + Time.time*2;
        float sin = Mathf.Sin(theta)*2;
        float cos = Mathf.Cos(theta);
        pos.y = startPos.y + sin;
        pos.x = startPos.x + cos;
        gameObject.transform.position = pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RepositioningToCam : MonoBehaviour
{
    //public float quantizeValue = 6.25f;
    //public float forwards = 10f;

    // Update is called once per frame
    void Update()
    {
        const float quantizeValue = 6.25f;
        const float forwards = 10f;

        var newPos = Camera.main.transform.TransformPoint(Vector3.forward * forwards);
        newPos.y = gameObject.transform.position.y;
        newPos.x = quantizeValue * (int)(newPos.x * quantizeValue);
        newPos.z = quantizeValue * (int)(newPos.z * quantizeValue);

        gameObject.transform.position = newPos;
        gameObject.transform.rotation = Quaternion.identity;
    }
}

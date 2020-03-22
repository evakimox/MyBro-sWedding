using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingApple : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (GetComponent<Animation>().isPlaying)
        {
            Vector3 curPos = transform.position;
            curPos.y = curPos.y - 0.015f;
            transform.position = curPos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorHandleRotationControl : MonoBehaviour
{
    public void UnlatchHandle(Vector3 position)
    {
        Vector2 pos = position;
        if (GeneralTools.Instance.IsObjAtPosition(gameObject, pos))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
        }
    }
}

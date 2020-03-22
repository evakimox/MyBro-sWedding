using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTouchReceiver : MonoBehaviour
{
    public GameObject redApple;
    public void LetApplesShake(Vector3 touchScreenPosition)
    {
        Vector2 fingerPos = touchScreenPosition;
        if (GeneralTools.Instance.IsObjAtPosition(gameObject, fingerPos))
        {
            int appleCount = transform.childCount;
            // 绿苹果
            for (int i = 0; i < appleCount; i++)
            {
                GameObject apple = transform.GetChild(i).gameObject;
                apple.GetComponent<Animation>().Play();
            }


            // 红苹果
            if (redApple == null || redApple.activeSelf == false)
            {
                return;
            }
            else
            {
                redApple.GetComponent<Animation>().Play();
            }
        }

        
    }


}

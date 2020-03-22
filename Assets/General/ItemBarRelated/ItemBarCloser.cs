using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBarCloser : MonoBehaviour
{
    public GameObject itemBar;
    public GameObject openButton;

    public void CloseItemBarCallback(Vector3 fingerPosition)
    {
        Vector2 fingerPos = fingerPosition;
        if (GeneralTools.Instance.IsObjAtPosition(gameObject, fingerPos))
        {
            CloseItemBar();
        }

    }

    public void CloseItemBar()
    {
        itemBar.transform.localScale = new Vector3(0f, 1f);
        openButton.SetActive(true);
        gameObject.SetActive(false);
    }
}

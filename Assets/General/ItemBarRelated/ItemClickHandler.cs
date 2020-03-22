using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class ItemClickHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTouch.OnFingerTap += OnTapItemButton;
    }

    public void OnTapItemButton(LeanFinger finger)
    {
        Vector3 fingerPos = finger.GetWorldPosition(10f, Camera.main);
        GameObject buttonItem = GeneralTools.Instance.ItemButtonAt(fingerPos);
        if (buttonItem != null)
        {
            overallDirector.Instance._selectedItemName = buttonItem.GetComponent<ShowDescription>().itemName;
        }
    }
}

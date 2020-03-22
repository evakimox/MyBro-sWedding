using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBarOpener : MonoBehaviour
{
    public GameObject itemBar;
    public GameObject closeButton;

    private void Start()
    {
        itemBar.transform.localScale = new Vector3(0f, 1f);
        closeButton.SetActive(false);
    }

    public void OpenItemBarCallback(Vector3 fingerPosition)
    {
        Vector2 fingerPos = fingerPosition;
        if(GeneralTools.Instance.IsObjAtPosition(gameObject, fingerPos))
        {
            OpenItemBar();
        }
        
    }

    public void OpenItemBar()
    {
        itemBar.transform.localScale = new Vector3(1f, 1f);
        closeButton.SetActive(true);
        gameObject.SetActive(false);
    }
}

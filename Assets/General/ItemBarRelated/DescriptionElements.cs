using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DescriptionElements : MonoBehaviour
{
    public GameObject spriteHolder;
    public GameObject textHolder;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSprite(Sprite useSprite, Color color) 
    {
        spriteHolder.GetComponent<SpriteRenderer>().sprite = useSprite;
        spriteHolder.GetComponent<SpriteRenderer>().color = color;
    }

    public void SetText(Sprite textSprite)
    {
        textHolder.GetComponent<SpriteRenderer>().sprite = textSprite;
    }

    public void Hide()
    {
        Vector3 pos = transform.position;
        pos.x = 2000f;
        transform.position = pos;
    }

    public void Show()
    {
        Vector3 pos = transform.position;
        pos.x = 0f;
        transform.position = pos;
    }

    public void OnLongPress(Vector3 fingerPos)
    {
        GameObject buttonItem = GeneralTools.Instance.ItemButtonAt(fingerPos);
        if (buttonItem  != null)
        {
            Sprite itemSprite = buttonItem.GetComponent<SpriteRenderer>().sprite;
            Color itemColor = buttonItem.GetComponent<SpriteRenderer>().color;
            SetSprite(itemSprite, itemColor);
            SetText(buttonItem.GetComponent<ShowDescription>().descriptionText);
            Show();
        }
    }

    public void OnLongPressRelease(Vector3 fingerPos)
    {
        Hide();
    }


}

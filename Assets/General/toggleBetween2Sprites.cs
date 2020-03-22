using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleBetween2Sprites : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite secondarySprite;
    public bool useDefault = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(useDefault && GetComponent<SpriteRenderer>().sprite != defaultSprite)
        {
            GetComponent<SpriteRenderer>().sprite = defaultSprite;
        }
        else if((!useDefault) && GetComponent<SpriteRenderer>().sprite != secondarySprite)
        {
            GetComponent<SpriteRenderer>().sprite = secondarySprite;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSwitchover : MonoBehaviour
{
    public GameObject leftButton;
    public bool useLeftButton = true;

    public GameObject rightButton;
    public bool useRightButton = true;
    

    void Start()
    {
        if(useLeftButton)
        {
            leftButton.SetActive(true);
        }
        else
        {
            leftButton.SetActive(false);
        }

        if (useRightButton)
        {
            rightButton.SetActive(true);
        }
        else
        {
            rightButton.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        
    }
}

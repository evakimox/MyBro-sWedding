using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterMaskGenerator : MonoBehaviour
{
    public GameObject waterMask;
    public float movingSpeed = 1f;
    public float distanceInterval = 3f;
    GameObject currentMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentMask == null)
        {
            Vector3 maskPosition = transform.position;
            maskPosition.y = maskPosition.y - distanceInterval;
            currentMask = Instantiate(waterMask, maskPosition, Quaternion.identity);
            currentMask.transform.parent = transform;
            currentMask.GetComponent<Rigidbody2D>().velocity = Vector2.up * movingSpeed;
        }

        Vector2 currentMaskPos = currentMask.transform.position;
        Vector2 myPosition = transform.position;
        float dist = (currentMaskPos - myPosition).magnitude;
        if(dist > distanceInterval)
        {
            Vector3 maskPosition = transform.position;
            maskPosition.y = maskPosition.y - distanceInterval;
            currentMask.transform.position = maskPosition;
        }
    }
}

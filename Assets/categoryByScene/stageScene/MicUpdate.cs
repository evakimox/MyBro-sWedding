using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        overallDirector.Instance.micPosition = transform.position;
    }
}

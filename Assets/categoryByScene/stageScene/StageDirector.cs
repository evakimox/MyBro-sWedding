using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDirector : MonoBehaviour
{
    public GameObject mic;
    // Start is called before the first frame update
    void Start()
    {
        GeneralTools.Instance.MoveObjTo(mic, overallDirector.Instance.micPosition); ;

    }

    // Update is called once per frame
    void Update()
    {

    }
}

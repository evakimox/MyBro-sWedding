using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjStates;

public class StudyDirector : MonoBehaviour
{
    public GameObject scissors;
    public GameObject thread;
    public GameObject needle;
    public GameObject globe;
    public GameObject basket;
    public GameObject earbuds;
    public GameObject diary;

    // Start is called before the first frame update
    void Start()
    {
        GeneralTools Tools = GeneralTools.Instance;
        overallDirector dir = overallDirector.Instance;
        Tools.MoveObjTo(scissors, dir.scissorsPosition);
        Tools.MoveObjTo(thread, dir.threadPosition);
        Tools.MoveObjTo(needle, dir.needlePosition);
        Tools.MoveObjTo(globe, dir.globePosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

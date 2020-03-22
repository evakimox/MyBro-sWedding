using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class TestLeanTap : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }


    void OnEnable()
    {
        LeanTouch.OnFingerTap += HandleFingerTap;
        LeanTouch.OnFingerOld += HandleFingerLong;
    }

    void OnDisable()
    {
        LeanTouch.OnFingerTap -= HandleFingerTap;
        LeanTouch.OnFingerOld -= HandleFingerLong;
    }

    void HandleFingerTap(LeanFinger finger)
    {
        Debug.Log("我轻点了屏幕哦");
    }

    void HandleFingerLong(LeanFinger finger)
    {
        Debug.Log("我长按了屏幕哦");
    }
}

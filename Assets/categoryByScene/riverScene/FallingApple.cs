using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class FallingApple : MonoBehaviour
{
    overallDirector director;
    Animation onTreeAnim;
    LeanFingerTap tapManager;
    GeneralTools tools;

    bool pickActivityRegistered;

    private void Start()
    {
        director = overallDirector.Instance;
        onTreeAnim = GetComponent<Animation>();
        tapManager = GameObject.Find("LeanCtrl").GetComponent<LeanFingerTap>();
        tools = GeneralTools.Instance;
        pickActivityRegistered = false;
    }

    private void FixedUpdate()
    {
        if (director.appleState == ObjStates.AppleState.OnTheTree)
        {
            TreePolicy();
        }

        if (director.appleState == ObjStates.AppleState.OnTheGround)
        {
            GroundPolicy();
        }

        if (director.appleState == ObjStates.AppleState.InBag)
        {
            if (pickActivityRegistered)
            {
                tapManager.OnPosition.RemoveListener(PickAppleFromGround);
            }
            Destroy(gameObject);
        }
    }

    void TreePolicy()
    {
        if (onTreeAnim.isPlaying)
        {
            Vector3 curPos = transform.position;
            curPos.y = curPos.y - 0.015f;
            transform.position = curPos;
        }
    }

    void GroundPolicy()
    {
        // lean touch点击自己时，添加效果到Lean Ctrl
        if (!pickActivityRegistered)
        {
            tapManager.OnPosition.AddListener(PickAppleFromGround);
        }
    }
    void PickAppleFromGround(Vector3 pos)
    {
        Vector2 fingerPos = pos;
        if (tools.IsObjAtPosition(gameObject, fingerPos))
        {
            director.appleState = ObjStates.AppleState.InBag;
        }
    }


    // 从树上掉到地上
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("redApplePickArea"))
        {
            director.appleState = ObjStates.AppleState.OnTheGround;
        }
    }


}

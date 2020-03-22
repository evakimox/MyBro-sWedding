using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralTools : MonoBehaviour
{

    public static GeneralTools Instance;

    private void InitializeInstance()
    {
        if (Instance != null & Instance == this)
            return;

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Awake()
    {
        InitializeInstance();
    }

    // 检查某点的位置有没有指定对象
    public bool IsObjAtPosition(GameObject obj, Vector2 position)
    {
        List<GameObject> allObjAtPos = allObjectsGivenPosition(position);
        foreach(GameObject curObj in allObjAtPos)
        {
            if(obj == curObj)
            {
                return true;
            }
        } 
        return false;
    }

    // 把对象移动到某位置，返回移动成功true，找不到对象返回false
    public bool MoveObjTo(GameObject obj, Vector2 pos, Quaternion rot)
    {
        if(MoveObjTo(obj, pos))
        {
            obj.transform.rotation = rot;
            return true;
        }
        return false;
    }
    public bool MoveObjTo(GameObject obj, Vector2 pos)
    {
        if ((obj == null) || (obj.activeSelf == false))
        {
            return false;
        }
        Vector3 objPos = obj.transform.position;
        objPos.x = pos.x;
        objPos.y = pos.y;
        obj.transform.position = objPos;
        return true;
    }

    // 非公开类，返回所有这个位置上的collider的对象
    List<GameObject> allObjectsGivenPosition(Vector2 position)
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(position, Vector2.zero);
        List<GameObject> hitObjects = new List<GameObject>();
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit2D hit = hits[i];
            hitObjects.Add(hit.collider.gameObject);
        }
        return hitObjects;
    }

    public GameObject ItemButtonAt(Vector2 position)
    {
        List<GameObject> allObjAt = allObjectsGivenPosition(position);
        foreach(GameObject obj in allObjAt)
        {
            if(obj.tag == "itemBarButton")
            {
                return obj;
            }
        }
        return null;
    }
}

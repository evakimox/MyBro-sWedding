using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextRoom : MonoBehaviour
{
    public string destinationRoom;

    void Start()
    {
    }

    public void TriangleTappedCallback(Vector3 position)
    {
        Vector2 pos = position;
        if(GeneralTools.Instance.IsObjAtPosition(gameObject, pos))
        {
            SceneManager.LoadScene(destinationRoom);
        }
    }
    
}

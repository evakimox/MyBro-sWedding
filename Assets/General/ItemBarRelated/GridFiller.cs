using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjStates;

public class GridFiller : MonoBehaviour
{
    public GameObject gridCollection;
    public GameObject description;

    public GameObject keyButton;
    public GameObject redAppleButton;
    public GameObject blackRoseButton;

    List<GameObject> grids;
    int fillIndex;
    // Start is called before the first frame update
    void Start()
    {
        fillIndex = 0;
        grids = new List<GameObject>();
        int gridCount = gridCollection.transform.childCount;
        for(int i = 0; i < gridCount; i++)
        {
            grids.Add(gridCollection.transform.GetChild(i).gameObject);
        }

        FillGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillGrid()
    {
        overallDirector director = overallDirector.Instance;
        List<string> itemNames = director._inBagItems;
        for(int i = 0; i < itemNames.Count; i++)
        {
            string item = itemNames[i];
            if(item == "key")
            {
                FillNext(keyButton);
            }
            if(item == "redApple")
            {
                FillNext(redAppleButton);
            }
            if(item == "blackRose")
            {
                FillNext(blackRoseButton);
            }
        }
    }

    void FillNext(GameObject buttonPrefab)
    {
        Transform buttonParent = grids[fillIndex].transform;
        GameObject button = Instantiate(buttonPrefab);
        button.transform.parent = buttonParent;
        button.transform.localScale = new Vector3(1f, 1f);
        button.transform.localPosition = Vector3.zero;
        fillIndex++;
    }

    
}

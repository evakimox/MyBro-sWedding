using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawFishingString : MonoBehaviour
{
    public GameObject destinationPt;
    public Color stringColor = Color.white;
    public float stringThickness = 0.05f;
    LineRenderer line;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 curPos = transform.position;
        Vector3 startPos = new Vector3(transform.position.x, transform.position.y, -1f);
        Vector3 endPos = new Vector3(destinationPt.transform.position.x, destinationPt.transform.position.y, -1f);
        AdjustAngle(startPos, endPos);
        DrawLine(startPos, endPos);
    }

    void DrawLine(Vector3 startPos, Vector3 endPos)
    {
        if (line == null)
        {
            line = gameObject.AddComponent<LineRenderer>();
        }
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.positionCount = 2;//设置两点
        line.startColor = stringColor;
        line.endColor = stringColor;
        line.startWidth = stringThickness;
        line.endWidth = stringThickness;

        line.SetPosition(0, startPos);
        line.SetPosition(1, endPos);
    }

    void AdjustAngle(Vector3 startPos, Vector3 endPos)
    {
        Vector2 s = startPos;
        Vector2 e = endPos;
        Vector2 d = e - s;
        float upper = d.normalized.y;
        float dnx2 = Mathf.Pow(d.normalized.x, 2);
        float dny2 = Mathf.Pow(d.normalized.y, 2);
        float lower = Mathf.Sqrt(dnx2 + dny2);
        float cosVal = upper / lower;
        float sinVal = d.normalized.x / lower;

        float acos = Mathf.Acos(cosVal);
        float rotateAngle = acos * 180f / Mathf.PI;
        if (sinVal > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -rotateAngle));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, rotateAngle));
        }

    }
}

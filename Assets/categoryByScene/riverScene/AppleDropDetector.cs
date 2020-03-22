using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDropDetector : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        
    }
}

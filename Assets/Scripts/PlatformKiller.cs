using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformKiller : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "platformKiller")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryOverName : MonoBehaviour
{
    public GameObject rootCanvas;

    void Awake()
    {
        DontDestroyOnLoad(rootCanvas);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    void Start()
    {
        int i = 10;

        while (i > 0)
        {
            Debug.Log($"i : {i--}");
        }
    }
}

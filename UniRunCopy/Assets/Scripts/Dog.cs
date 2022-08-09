using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string dogName; // 개의 이름
    public static int count = 0;

    private void Awake()
    {
        count++;
        Debug.Log(dogName);
        Debug.Log(count);
    }
}

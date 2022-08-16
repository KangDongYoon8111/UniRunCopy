using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    void Start()
    {
        int[] class1 = new int[5] { 10, 20, 30, 40, 50 };
        class1 = new int[6] { 10, 20, 30, 40, 50, 60 };

        int sum1 = 0;
        foreach (int a in class1)
        {
            sum1 += a;
        }
        Debug.Log($"{class1.Length}명 학생의 평균은 {sum1 / class1.Length}");

        Debug.Log($"6명 학생의 평균은 {sum1 / 6}");
    }
}

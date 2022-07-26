using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        string userClass = "4";
        string userInput = "65";
        int number = int.Parse(userClass);
        int value = int.Parse(userInput);

        if (value > 100 || value < 0 || number > 4 || number < 1)
        {
            Debug.Log("경고!!!");
            return;
        }

        string value2;
        if(number == 4)
        {
            if(value >= 70)
            {
                value2 = "합격";
            }
            else
            {
                value2 = "불합격";
            }

            value2 = value >= 70 ? "합격" : "불합격";
        }
        else
        {
            if(value >= 60)
            {
                value2 = "합격";
            }
            else
            {
                value2 = "불합격";
            }
            value2 = value >= 60 ? "합격" : "불합격";
        }

        Debug.Log($"입력하신 {number}학년의 점수{value}는 {value2}입니다.");

    }

}

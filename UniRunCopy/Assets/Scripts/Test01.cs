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
            Debug.Log("���!!!");
            return;
        }

        string value2;
        if(number == 4)
        {
            if(value >= 70)
            {
                value2 = "�հ�";
            }
            else
            {
                value2 = "���հ�";
            }

            value2 = value >= 70 ? "�հ�" : "���հ�";
        }
        else
        {
            if(value >= 60)
            {
                value2 = "�հ�";
            }
            else
            {
                value2 = "���հ�";
            }
            value2 = value >= 60 ? "�հ�" : "���հ�";
        }

        Debug.Log($"�Է��Ͻ� {number}�г��� ����{value}�� {value2}�Դϴ�.");

    }

}

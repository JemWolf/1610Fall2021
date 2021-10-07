using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        int month = 10;
        switch (month)
        {
            case 1:
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("February");
                break;
            case 3:
                Debug.Log("March");
                break;
            case 4:
                Debug.Log("April");
                break;
            case 5:
                Debug.Log("May");
                break;
            case 6:
                Debug.Log("June");
                break;
            case 7:
                Debug.Log("July");
                break;
            case 8:
                Debug.Log("August");
                break;
            case 9:
                Debug.Log("September");
                break;
            case 10:
                Debug.Log("October");
                break;
            case 11:
                Debug.Log("November");
                break;
            case 12:
                Debug.Log("December");
                break;
        }
    }
    
}

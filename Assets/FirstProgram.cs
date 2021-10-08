using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstProgram : MonoBehaviour
{
    int number = 10;

    void Start()
    {
        int i = 0;
        while (number < 20) {

            Debug.Log(""+number);

            i++;
            if(i>=2)break;
        }
        
    }
}
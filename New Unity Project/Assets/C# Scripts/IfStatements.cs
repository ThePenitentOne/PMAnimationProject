using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotTemp = 180.0f;
    float coldTemp = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        //coffeeTemp = coffeeTemp - Time.deltaTime * 5
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }   
    }
    void TemperatureTest()
    {
        //too hot
        if(coffeeTemp > hotTemp)
        {
            Debug.Log("Ouch! I burned my tongue");
        }
        else if(coffeeTemp < coldTemp)
        {
            Debug.Log("Ugh. cold coffee is gross");
        }
        //just right
        else
        {
            Debug.Log("Mmmmm coffee coffee coffee");
        }

    }
   
}

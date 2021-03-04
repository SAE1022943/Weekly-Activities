using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFour : MonoBehaviour
{

    /// <summary>
    /// Function for calculating leap years using Modulus operator
    /// </summary>
    /// <param name="_Year"></param>
    public void LeapYearTest(int _Year)
    {
        if (_Year % 4 == 0)
        {
            Debug.Log("Yep");
        }
        else
        {
            Debug.Log("Nop");
        }
    }



    /// <summary>
    /// Creates a float variable that will take Fahrenheight and convert to Celcius
    /// </summary>
    /// <param name="_FDeg"></param>
    /// <returns></returns>
    public float ConvertedFDegtoCDeg(float _FDeg)
    {
       return ((_FDeg - 32) * ((float)5 / (float)9));
    }


    public void ImCool(float _Temp)
    {
        if (_Temp < 0)
        {
            Debug.Log("Popscicle!");
        }
        else if (_Temp > 0 && _Temp < 10)
        {
            Debug.Log("So cold...");
        }
        else if (_Temp >= 10 && _Temp < 20)
        {
            if (_Temp < 13 || _Temp == 14)
            {
                Debug.Log("Super Cool");
            }
            else
            {
                Debug.Log("It's cold weather");
            }
        }
        else if (_Temp >= 20 && _Temp < 30)
        {
            Debug.Log("Ahhhh, nice n normal.");
        } 
        else if (_Temp >= 30 && _Temp < 40)
        {
            if(_Temp < 35)
            {
                Debug.Log("Ooof, getting sweaty");
            }
            else if (_Temp > 35)
            {
                Debug.Log("I'm melting!!!");
            }
        } 
        else
        {
            Debug.Log("I'm coooking!");
        
        } 
       
    }

    // Start is called before the first frame update
    void Start()
    {
        LeapYearTest(2000);
        ConvertedFDegtoCDeg(70);
        ImCool(ConvertedFDegtoCDeg(70));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

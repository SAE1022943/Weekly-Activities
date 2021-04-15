using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class FloatTimer : MonoBehaviour
{

    //public UnityEvent timerStopped;
    
    private float timerElapsed;
    public float stopTime;

    // Update is called once per frame
    void Update()
    {
        if(timerElapsed <= stopTime) 
        {
            timerElapsed += Time.deltaTime;
        } 
        else
        {

            //timerStopped?.Invoke();


            int mins = (int)(timerElapsed / 60f);
            int seconds = (int)(timerElapsed % 60f);           
            string message = string.Format("the time is {0}m and {1}s", mins, seconds);

            Printer.printMessageEvent?.Invoke(message);            

            enabled = false;
        }
    }
}

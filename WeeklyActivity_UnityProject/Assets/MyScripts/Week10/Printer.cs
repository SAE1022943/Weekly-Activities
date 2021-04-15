using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Printer : MonoBehaviour
{

    public delegate void PrintMessage(string message); // declaration of my delegate
    public static PrintMessage printMessageEvent; // creates the instance of my event


    private void OnEnable()
    {
        printMessageEvent += Print;
    }

    private void OnDisable()
    {
        printMessageEvent -= Print;
    }

    public void Print(string _messageToPrint)
    {
        Debug.Log(_messageToPrint);
    }

}

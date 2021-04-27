using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private GameManager gameManagerRef;


    // Add listeners
    private void OnEnable() // add listener
    {
       // add the delegate listener
              

    }

    private void OnDisable() // remove listener
    {
        
    }

    // Start is called before the first frame update
    void ShowGameUI()
    {
        Debug.Log("Hi I'm the UI");
    }

}

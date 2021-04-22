using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    // Declare delegate data type
    private delegate void VoidDelegate();
    private static VoidDelegate onGameStart;


    // Create a instance of delegate data type

  
    // Start is called before the first frame update
    private void Start()
    {
        // Invoke the delegate onGameStart?.Invoke();     
        onGameStart?.Invoke();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

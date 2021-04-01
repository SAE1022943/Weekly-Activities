using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create the for loop to go through 
        for (int i = 0; i <= 100; i++)
        {
            // check if i is divisible by 3 AND 5
            // use modulus to see if there is not remainder
            // use AND operator to make sure both conditions are true
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            // else check if it's divisible by 3 and not 5
            // use the not equal operator so second condition is true if it's not equal to zero
            else if (i % 3 == 0 && i % 5 != 0)
            {
                Debug.Log("Fizz");
            }
            // else check if it's divisible by 5
            // don't need to do a condition for not 3 because this was previously checked.
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            // otherwise just print the number of i 
            else 
            {
                Debug.Log(i);
            }
        }         
    }

}

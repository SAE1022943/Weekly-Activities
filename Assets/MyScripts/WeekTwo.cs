

/// <summary>
/// This script is for Week 2 GAD170 in class activities
/// </summary>


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class is for the week 2 activities exercises
// ojbectives of this 

public class WeekTwo : MonoBehaviour
{

    // Public variables

    public string favouriteGameName; // a string of my favourite game
    public float gameCost; // the cost of my game
    public int gameHoursPlayed; // the time I have spent playing the game
    
    // Start is called before the first frame update
    void Start()
    {


     /* Debugging: - 12 mins
        * Open up your WeekTwoActivities script and create variables to hold the following information, add comments to all of these to describe their purpose:
        * The name of your favourite game.
        * How many hours you have played it for.
        * How much it cost you to purchase.
        * Create a debug log that prints out once the following : “My Favourite game is ___, I have played it for ___, it cost me _____, therefore my value of dollar per hour is: ____.”
        * Commit and push up your changes. */

        //Debug log outputs
        Debug.Log("My favourite game is " + favouriteGameName + "I played it for " + gameHoursPlayed + 
                  "hr, It cost me $" + gameCost + " therefore my dollar per hour is: $" + System.Math.Round((gameCost/gameHoursPlayed),2));

        /*  Below this, create a temporary variable to hold a random float, between 1 and 10, leave a comment for its purpose.
                Next perform a series of debug logs based on the following conditions:
                    “The number was 1” given the number was exactly one.
                    “The number is greater than 3” given the number was more than 3.
                    “The number was less than 3 or the number was greater than 3 but less than 5” given the number was less than 3 or the number was greater than 3 but less than 5. Else debug, “The number was exactly 4!”.
                    “The number was greater than 1 and less than 5 or the number was greater than 7” given the number was greater than 1 and less than 5 or the number was greater than 7. */

        float myRandomFloat;
        myRandomFloat = Random.Range(1.0f, 10.0f); // Generates a random range between 1 and 10


        // () parentheses
        // {} braces
        // [] brackets
        // = gets
        // == equal to
        // ; end line
        // || or
        // && and

        if (myRandomFloat == 1.0f)
        {
            Debug.Log("The number was 1” given the number was exactly one");
        }
        
        if (myRandomFloat > 3.0f) {
            Debug.Log("The number is greater than 3” given the number was more than 3");
        } 
        
        if (myRandomFloat < 3f || (myRandomFloat > 3f && myRandomFloat < 5f)) {
            Debug.Log("The number was less than 3 or the number was greater than 3 but less than 5");
        } 
        
        if ((myRandomFloat > 1f && myRandomFloat > 5f) || myRandomFloat > 7f)
        {
            Debug.Log("The number was greater than 1 and less than 5 or the number was greater than 7");
        } 
        else 
        {
            Debug.Log("The number was 4");
        }

        if ((myRandomFloat > 1f && myRandomFloat < 5) || myRandomFloat > 7f) // always use paratheses to help understand the argument order. 
        {
            Debug.Log("The number was greatenr than one and less than five or the number was greater than 7");
        }

    }

}

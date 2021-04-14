using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOne : MonoBehaviour
{

    /* 
    
    Debugging: - 12 mins
        
        Open up your WeekTwoActivities script and create variables to hold the following information, add comments to all of these to describe their purpose:
        The name of your favourite game.
        How many hours you have played it for.
        How much it cost you to purchase.
        Create a debug log that prints out once the following : “My Favourite game is ___, I have played it for ___, it cost me _____, therefore my value of dollar per hour is: ____.”
        Commit and push up your changes.
    
    */

    private string myFavouriteGame = "DeepRockGalactic";
    private int hoursPlayed = 100;
    private double gameCost = 40.00f;


    public void PrintMyGameStuff()
    {

        var message = "My favourite game is" + myFavouriteGame + ". I have played it for " + hoursPlayed + " it cost me " + gameCost + " therefore my value of dollar per hours is: " + gameCost / hoursPlayed);     
        Debug.Log(message);

    }


    /*

    IF Statements: - 15 mins
        
        Below this, create a temporary variable to hold a random float, between 1 and 10, leave a comment for its purpose.
        Next perform a series of debug logs based on the following conditions:
            Debug “the number was exactly one”.
            Debug “The number was greater than three”.
            Debug “The number was less than three or greater than 5” else Debug “the number was exactly 4” 
            Debug “the number was greater than one, and less than 5, or the number was greater than 7”.


    */


    private float randomFloat; // this is my comment about the float being to store a value between 1 and 10;

    public void 







    /*

        Create Some Stats! - 15 mins
            Create some variables to store the following stats: strength, agility and intelligence, and a variable for stat pool of 20.
            Next assign a random amount of points from the stat pool to each of your stats removing the amount of stat points from the pool each time they are assigned. I.e. strength gets the random number 7, there are now 13 stat points left, agility now gets a random number between 0 and 13.
            Debug out your assigned stats. 
            Commit and Push your finished work up to your GitHub Repo with an appropriate commit message that details what you have completed this lesson. 

    */



    /*

        Extra Challenge:
            Create a system that simulates a coin flip which displays/logs out if it’s heads, tails, or a Draw.
            Write in a new script, a system that given two numbers, logs out if they should be added, subtracted, multiplied or divided to get 24. If none of the operations can give 24, debug out nothing.

    */

    // Start is called before the first frame update
    void Start()
    {

        PrintMyGameStuff();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

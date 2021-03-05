using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Stats Manager implementation
/// </summary>


public class WeekThree : MonoBehaviour
{

    // Declaration of integers for stats
    public int statStrength;
    public int statAgility;
    public int statSmarts;

    // total amount of 
    public int statsPool = 20;



    public void StatManager()
    {
        statStrength = Random.Range(statStrength, (statsPool / 3));
        statsPool -= statStrength;

        statAgility = Random.Range(statAgility, (statsPool / 3));
        statsPool -= statAgility;

        statSmarts = Random.Range(statSmarts, (statsPool / 3));
        statsPool -= statSmarts;

        Debug.Log("Str = " + statStrength + "Agil = " + statAgility + "Smart = " + statSmarts);


        Debug.Log(CalculatePowerLevel(10, 10, 10)); // Test case, give expected data and see if the expected output is correct test is complete.
    }


    // Start is called before the first frame update
    void Start()
    {
        // StatManager();

        // PrintName(Adam, O'Donoghue);
        // PrintName(Silly, Seal);

        // ConvertAge(30)

        // Debug.log(ConvertAgeAsString(30));

    }

    // Activity 1 create function that prints our my name
    // start with access type, then return type, then name, then parameters.



    /// <summary>
    /// Use Summaries to describe what functions do. 
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public void PrintName(string _FirstName, string _LastName)
    {

        // THis is the basic way, remember to call in start or update functions.  
        Debug.Log("My name is Adam O'Donoghue");    

        //This is using parameters to pass data into the code. 
        Debug.Log("My name is " + _FirstName + " and my surname is " + _LastName); 

    }

    // Activity 2 create function that prints our my name
    // start with access type, then return type, then name, then parameters.





    /// <summary>
    /// 
    /// </summary>
    /// <param name="_Age"></param>
    public void ConvertAge(int _Age)
    {
        int months = _Age * 12;
        int weeks = months * 4;
        int days = weeks * 7;
        int hours = days * 24;
        int mins = hours * 60;
        int secs = mins * 60;

        Debug.Log(months + " Months " +
                  weeks + " Weeks " +
                  days + " Days " +
                  hours + " Hours " +
                  mins + " Minutes " +
                  secs + " Seconds " );

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_Age"></param>
    /// <returns></returns>
    public string ConvertAgeAsString(int _Age)
    {
        int months = _Age * 12;
        int weeks = months * 4;
        int days = weeks * 7;
        int hours = days * 24;
        int mins = hours * 60;
        int secs = mins * 60;


        string output = months + " Months " +
                        weeks + " Weeks " +
                        days + " Days " +
                         hours + " Hours " +
                       mins + " Minutes " +
                          secs + " Seconds ";

        return output;

    }

    /// <summary>
    /// .
    /// </summary>
    /// <param name="_Strength"></param>
    /// <param name="_Agility"></param>
    /// <param name="_Smarts"></param>
    /// <returns></returns>
    public int CalculatePowerLevel(int _Strength, int _Agility, int _Smarts) 
    {
                 
        int powerLevel = (_Strength * 2) + (int)(_Agility * 1.5f) + _Smarts; // this is called casting
        return powerLevel;
    }



    /// <summary>
    /// Finally Create a function that takes in two players power levels, 
    /// compare the two power levels and 
    /// Debug log out: 
    /// The winner is:____, player one had ____ power level and player two had ___ power level. 
    /// The winner won by_____percent. Hint you will need convert ints into floats.
    /// </summary>
    /// <param name="_PlayerOne"></param>
    /// <param name="_PlayerTwo"></param>
    public void ComparePowerLevels(int _PlayerOne, int _PlayerTwo) 
    {
       if(_PlayerOne == _PlayerTwo)
        {
            Debug.Log("It is a draw!");
        }
       
       if(_PlayerOne > _PlayerTwo)
        {
            Debug.Log("The winner is player 1 with " + _PlayerOne + " and player 2 had a score of " + _PlayerTwo + " And they won by " + (int)(1-((float)_PlayerTwo / (float)_PlayerOne) * 100) + "%");
        }

       if (_PlayerOne < _PlayerTwo)
        {
            Debug.Log("The winner is player 2 with " + _PlayerTwo + " and player 2 had a score of " + _PlayerOne + " And they won by " + (int)(1-((float)_PlayerOne / (float)_PlayerTwo) * 100) + "%");
        }

    }

}
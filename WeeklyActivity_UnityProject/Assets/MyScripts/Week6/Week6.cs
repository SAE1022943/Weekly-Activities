using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// Week 6 class activities
/// * 1 reverse a string 
/// * 2 find the sums of all the odd numbers in a number array 
/// </summary>
public class Week6 : MonoBehaviour
{
    public string myNameString = "Adam";

    private string ReverseString(string nameToReverse)
    {
        string nameThatIsReversed = "";
        for (int i = nameToReverse.Length - 1; i >= 0; i--) //
        {
            nameThatIsReversed += nameToReverse[i];
        }
        return nameThatIsReversed;
    }


    public float total;

    private float SumOnlyOddNumbers(int maximum)
    {        
        for (int i = 0; i < maximum; i++)
        {
            if (i % 2 == 0)
            {
                
            } else
            {
                total =+ i;
            }
        }
        return total;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ReverseString(myNameString));
        SumOnlyOddNumbers(6);
    }

}

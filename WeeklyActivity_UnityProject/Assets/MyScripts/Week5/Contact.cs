using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that contains contact details of a person.
/// This class will be instantiated by the class directory class and stored in an array.
/// </summary>
public class Contact : MonoBehaviour
{
    private string Name { get; set; } // use string 
    private string PhoneNumber { get; set; } // use a string because don't want to do math operations
    private string Address { get; set; } // 
    private string Email { get; set; } //
    private string PreferedName { get; set; } //

    public Contact(string _name, string _phoneNumber, string _Email, string _PreferedName) { }

    public void SetUpContact()
    {
              
        // Create a set of contact objects to select from
        Contact optionOne = new Contact("charles", "0304-0497", "ILoveCerebro@xmail.edu.usa", "Professor X");
        Contact optionTwo = new Contact("Harry", "0304-5555", "BigBlueBrain@xmail.edu.usa", "Harry Beast");
        Contact optionThree = new Contact("Logan", "0304-7787", "HugeJaxMan@xmail.edu.usa", "Wolverine");
        Contact optionFour = new Contact("Jean", "0304-4572", "RedHeadedPheonix@xmail.edu.usa", "Dr Gray");
        Contact optionFive = new Contact("Scott", "5213-9263", "IHateLogan@xmail.edu.usa", "Cyclo");
        Contact optionSix = new Contact("Kitty", "0304-7774", "NotAWallBanger@xmail.edu.usa", "Phase");

        // put the contacts into an array for selection into 
        Contact[] optionsArray = new Contact[5];

        // Assign the contacts into an array
        optionsArray[0] = optionOne;
        optionsArray[1] = optionTwo;
        optionsArray[2] = optionThree;
        optionsArray[3] = optionFour;
        optionsArray[4] = optionFive;
        optionsArray[5] = optionSix;

        // create three selection references
        //Contact selectedOne = null;
        //Contact selectedTwo = null;
        //Contact selectedThree = null;

        // Random selection
        for (int i = 3; i > 0; i--)
        {
            if (Random.Range(0, 5) == 0)
            {
                // selectedOne =
                // selectedTwo =
                // selectedThree =

            }

        }

     }

    /*
    public Contact SelectContact(Contact _selection, Contact _array, int _index) 
    {
        if (_selection == null)
        {
            _selection = _array[0];
            return _selection;
        }
        else if (selectedTwo == null)
        {
            _selection = optionsArray[0];
            return
        }
        else
        {
            selectedThree = optionsArray[0];
        }


    }
    */

 }


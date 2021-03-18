using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrestlingManager : MonoBehaviour
{

    public List<string> firstNames = new List<string>() { "Burb", "Dibb", "Dagg", "Ba", "Gurp" };
    public List<string> lastNames = new List<string>() { "Waka", "Tiki", "Riki", "Koki", "Paka" };
    public List<string> wrestlerNames = new List<string>() {"Da", "Der", "Lil", "Ser", "De"};
    public List<Wrestler> allWrestlers = new List<Wrestler>(); 


    // Start is called before the first frame update
    void Start()
    {
        


        for (int i = 0; i < allWrestlers.Count; i++)
        {
                        
            allWrestlers[i].firstName = firstNames[Random.Range(0,firstNames.Count)];

            allWrestlers[i].lastName = lastNames[Random.Range(0, lastNames.Count)];

            allWrestlers[i].wrestlerName = lastNames[Random.Range(0, wrestlerNames.Count)];

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject capsulePrefab; // reference to my capsule object


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {          
            var spawnLocation = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
            var myClone = Instantiate(capsulePrefab, spawnLocation, Quaternion.identity);
        }

    }

}

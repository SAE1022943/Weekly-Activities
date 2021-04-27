using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{

    public GameObject fireParticle;

    public bool useRayCast;


    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0)) // check if the mouse has been clicked
        {


            if (useRayCast) // doing this to get intelisense 
            {

                Debug.Log("mouse clicked");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // search scene for main camera, call the function, and convert from screen to world space.
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f))
                {
                    Instantiate(fireParticle, hit.point, Quaternion.identity); // spawn the particle
                    Debug.DrawRay(ray.origin, ray.direction, Color.blue, 5);
                }

            }
            else
            {

                // Vector3 mouseposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ??? ); 
                // Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mouseposition);
                // Instantiate(fireParticle, spawnPosition, Quaternion.identity);

            }

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SkyFalling : MonoBehaviour
{

    
    public float hp = 100f; // health of the cube, when 0 the cube dies
    public UnityEvent onDeath = new UnityEvent(); // event to call the kill function for this game object

    

    /// <summary>
    /// Runs when any object collides with my object
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I got hit");
        DealDamage(25);
        Vector3 newPosition = new Vector3(0, 3, 0);
        collision.transform.position = transform.position + newPosition;
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    }


    /// <summary>
    /// Deal damage to the cube passed in as a float
    /// </summary>
    /// <param name="amount"></param>
    private void DealDamage(float amount)
    {

        hp -= amount; // decriment health by amount passed

        if(hp < 0) // check if not dead
        {
            
            if(onDeath != null) // check if their is one instance of the event otherwise will throw and error.
            {
                onDeath.Invoke(); // trigger the event
            }

            // or could do the shorter version

            // onDeath?.Invoke();

        }

    }

    //
    public void Kill()
    {
        Destroy(gameObject);
    }



}

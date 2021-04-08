using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SkyFalling : MonoBehaviour
{

    public float hp = 100f;
    public UnityEvent onDeath = new UnityEvent();

    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I got hit");
        DealDamage(25);
        Vector3 newPosition = new Vector3(0, 3, 0);
        collision.transform.position = transform.position + newPosition;
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    }


    // got weird 
    //private void OnCollisionEnter(UnityEngine.Collision collision)
    //{
    //    Debug.Log("I got hit");
    //    DealDamage(25);
    //    Vector3 newPosition = new Vector3(0, 3, 0);
    //    collision.transform.position = transform.position + newPosition;
    //    collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    //}

    private void DealDamage(float amount)
    {

        hp -= amount;

        if(hp < 0)
        {
            
            if(onDeath != null)
            {
                onDeath.Invoke();
            }

            // or
            // onDeath?.Invoke();

        }

    }

    public void kill()
    {
        Destroy(gameObject);
    }



}

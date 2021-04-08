using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderLord : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        Vector3 newPosition = new Vector3(0, Random.Range(10f, 20f), 0); // set a random position to fall from
        collision.transform.position = transform.position + newPosition; // get the colliding objects transform and modify it by adding the vectors
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; // set the velocity of the object to 0 so it drops
    }

}

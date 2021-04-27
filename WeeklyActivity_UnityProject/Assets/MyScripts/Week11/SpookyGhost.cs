using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyGhost : MonoBehaviour
{

    public GameObject ghostParticle;
    
    public List<ParticleSystem> allParticles = new List<ParticleSystem>();

    private void Start()
    {
        ParticleSystem[] tempParticles = ghostParticle.GetComponentsInChildren<ParticleSystem>(); // my array of particles
        allParticles.AddRange(tempParticles);
        EnableParticles(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        EnableParticles(true);
    }

    private void OnTriggerExit(Collider other)
    {
        EnableParticles(false);
    }

    private void EnableParticles(bool Enabled)
    {
        
        for (int i = 0; i < allParticles.Count; i++)
        {
            if (Enabled) // Make sure its a Capital E...
            {
                allParticles[i].Play();
            }
            else
            {
                allParticles[i].Stop();
            }
        }
                
    }



}

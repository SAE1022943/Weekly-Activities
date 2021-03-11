using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDropper : MonoBehaviour
{

    public Rigidbody rigidBody;
    public MeshRenderer meshRenderer;

    public KeyCode resetButton = KeyCode.Space;
    public Vector3 startPos;  
            
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();      
        rigidBody.mass = 50;

    }

    // Update is called once per frame
    void Update()
    {
      
      


    }

    private void ChangeColour()
    {
        meshRenderer.material.color = Color.red;
    }


}

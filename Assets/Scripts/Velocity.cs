using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    // Start is called before the first frame update
   // public GameObject squaree;
    Rigidbody2D Rb;
   // public Rigidbody rb;
    //public RigidBody Rb { get => rb; set => rb = value; }
    public float a;
    void Start()
    {   
        a=spawner.a;
        Rb=GetComponent<Rigidbody2D>();
        Rb.velocity=new Vector3(0,-a,0);
        
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}

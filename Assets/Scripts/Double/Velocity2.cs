using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Velocity2 : MonoBehaviour
{ 
       Rigidbody2D Rb;
       private float a=12f;
   // public Rigidbody rb;
    //public RigidBody Rb { get => rb; set => rb = value; }

    void Start()
    {   
        a=Spawnside.a;
        Rb=GetComponent<Rigidbody2D>();
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="Side D"||scene.name=="START FINAL")
        {
            Rb.velocity=new Vector3(-a,0,0);
        }
        else
        {
            Rb.velocity=new Vector3(0,-a,0);
        }
    }
    // Update is called once per frame
 /*   void FixedUpdate()
    {
        a=a+0.01f;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class destroy : MonoBehaviour
{

    void Update()
    {
        

        Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="Side D"||scene.name=="START FINAL")
        {
            if(this.transform.position.x<-10)
            {
               Destroy(this.gameObject);
            }
        }
        else
        {
            if(this.transform.position.y<-20)
            {
               Destroy(this.gameObject);
            }
        }
    }
}

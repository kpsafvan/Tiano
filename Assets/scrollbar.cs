using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollbar : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar bar; 
    public Scrollbar bar2; 
    void Start()
    {
       bar.value=0;
       bar2.value=0;
 

    }

    // Update is called once per frame
    public void letgo()
    {
        if(bar.value<1)
        {
            bar.value=0;
        }    
         if(bar2.value<1)
        {
            bar2.value=0;
        } 
    }
}

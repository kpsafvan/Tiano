using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sense2 : MonoBehaviour
{

    // Update is called once per frame
   // public GameObject abc;
    void Start() 
    {
      // Debug.Log(Score.value); 
    }
    private void Update()
        {  int i = 0;
        while (i < Input.touchCount)
        {

            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
               // var localHit =new Vector3(0f,0f,0f);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), -Vector2.up);
              /*  if(i%2==0){
                    localHit = transform.InverseTransformPoint(hit.point);
                }
                else{    
                    localHit = transform.InverseTransformPoint(hit.point);
                }
                */
              //  Debug.Log(localHit.x+" y "+localHit.y+ " total "+localHit);
              //  Debug.Log(hit.point);
              //  Instantiate(abc,new Vector3(hit.point.x,hit.point.y,0), Quaternion.identity);
                if (hit.collider != null)
                {
                  //  Debug.Log(hit.transform.position);
                  //  Debug.Log(hit.collider.tag);
                    if(hit.collider.tag=="down")
                    {
                        Score2.valuedown++;
                    }
                     if(hit.collider.tag=="up")
                    {
                        Score2.valueup+=3;
                    }
                     if(hit.collider.tag=="sq3")
                    {
                        Score.value+=2;
                    }
                }
               /* else
                {
                        if(Score2.value>0)
                        Score.value-=1;
                }*/
            }
            ++i;
        }

    
        }
}
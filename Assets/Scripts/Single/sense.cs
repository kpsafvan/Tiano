using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sense : MonoBehaviour
{
    public GameObject pause;
    public GameObject sq;
    public Scrollbar asa;
    // Update is called once per frame
    void Start() 
    {
        pause.SetActive(false);
    }
    private void Update()
        {  int i = 0;
        while (i < Input.touchCount)
        {

            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), -Vector2.up,0f);
            
                
                if (hit.collider != null&&Time.timeScale==1)
                {

                    if(hit.collider.tag=="sq1")
                    {
                        Score.value++;
                    }
                     if(hit.collider.tag=="sq2")
                    {
                        Score.value+=3;
                    }
                     if(hit.collider.tag=="sq3")
                    {
                        Score.value+=2;
                    }
                    if(hit.collider.tag=="life")
                    {
                        life.lives--;
                    }
                /*    if(hit.collider.tag=="Respawn")
                    {
                        Debug.Log("SAD");
                        SceneManager.LoadScene("STAR FINAL");
                    }*/
                    if(hit.collider.tag=="pause")
                    {
                        Debug.Log("sdsdffsadfsdafsda");
                            pause.SetActive(true);
                            Time.timeScale=0;
                            sq.SetActive(false);
                    }
               /*     else if(hit.collider.tag=="up1")
                    {
                        pause.SetActive(false);
                        Time.timeScale=1;
                        sq.SetActive(true);
                         Debug.Log("sdsdf");
                    }
                    else if(hit.collider.tag=="up2")
                    {
                        pause.SetActive(false);
                        Time.timeScale=1;
                        sq.SetActive(true);
                        SceneManager.LoadScene("STAR FINAL");

                    }
*/
                    else
                    {
                    Destroy(hit.collider.gameObject);
                    }
                }
                else
                {
                        if(Score.value>0)
                        Score.value-=1;
                }
            }
            ++i;
        }

    
        }
        public void cont(float slide)
        {
            if(slide==1)
            {
                pause.SetActive(false);
                Time.timeScale=1;
                sq.SetActive(true);
                Debug.Log("sdsdf");
                asa.value=0;
            }
        }
        public void exi(float slide)
        {
            if(slide==1)
            {
                pause.SetActive(false);
                Time.timeScale=1;
                sq.SetActive(true);
                asa.value=0;
                SceneManager.LoadScene("START FINAL");

            }
        }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class senseside : MonoBehaviour
{

    public GameObject pause;
    public GameObject sq;
    public GameObject sq2;

    
    public Scrollbar asa;
    //public GameObject abc;

    

    // Update is called once per frame
    void Start() 
    {
      // Debug.Log(Score.value); 
      pause.SetActive(false);
     // audioData = GetComponent<AudioSource>();
        
    }
    private void Update()
        {  int i = 0;
        while (i < Input.touchCount)
        {
            //audioData.Play(0);
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), -Vector2.up,0f);
                //Instantiate(abc,new Vector3(hit.point.x,hit.point.y,0), Quaternion.identity);
                
                if (hit.collider != null)
                {

                    if(hit.collider.tag=="up1")
                    {
                        Scoreside.valueup++;
                        //Scoreside.audio1p();
                       // GetComponent<AudioSource>().Play();
                    }
                    if(hit.collider.tag=="up3")
                    {
                        Scoreside.valueup+=3;
                       // GetComponent<AudioSource>().Play();
                    }
                    if(hit.collider.tag=="up2")
                    {
                        Scoreside.valueup+=2;
                        //GetComponent<AudioSource>().Play();
                    }
                    if(hit.collider.tag=="down1")
                    {
                        Scoreside.valuedown++;
                    }
                    if(hit.collider.tag=="down3")
                    {
                        Scoreside.valuedown+=3;
                    }
                    if(hit.collider.tag=="down2")
                    {
                        Scoreside.valuedown+=2;
                    }
                    if(hit.collider.tag=="sq2")
                    {
                        Scoreside.valuedown-=2;
                        if(Scoreside.valuedown<0)
                        {
                            Scoreside.valuedown=0;
                        }
                    }
                     if(hit.collider.tag=="sq1")
                    {
                        Scoreside.valueup-=2;
                        if(Scoreside.valueup<0)
                        {
                            Scoreside.valueup=0;
                        }
                    }
                    if(hit.collider.tag=="pause")
                    {
                        Debug.Log("sdsdffsadfsdafsda");
                            pause.SetActive(true);
                            Time.timeScale=0;
                            sq.SetActive(false);
                            sq2.SetActive(false);
                    }
                    else
                    {
                        Debug.Log("hittt");
                    Destroy (hit.collider.gameObject);
                    }
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
                sq2.SetActive(true);
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
                sq2.SetActive(true);
                asa.value=0;
                SceneManager.LoadScene("START FINAL");

            }
        }
}
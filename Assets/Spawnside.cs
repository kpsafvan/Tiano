using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnside : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject white1; 
    public GameObject white2;
    public GameObject white3;
      public GameObject black1; 
    public GameObject black2;
    public GameObject black3;
    public GameObject redup;
    public GameObject reddown;
    public int height = 2;
    public float width ;
  //  private float val = 1.56f;
    public float time1 =0f;
    public float time2 =0f;
    public float time3 =0f;
    private Vector3 location;
    private  float timea=1f,timeb=0f,timec=0f;
    private int x;
    public static float a=4f;
    public float s;
    public float t=0f;
    public int y;
     void Update()
    {
        s=a;
        time1=time1+ Time.deltaTime;
        time2=time2+ Time.deltaTime;
        time3=time3+ Time.deltaTime;

        if(time1>timea)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(white1, new Vector3(10.5f,1f,0),  Quaternion.Euler(0, 0, 90));
            Instantiate(black1, new Vector3(10.5f,-1f,0), Quaternion.Euler(0, 0, 90));
            timea=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(white2, new Vector3(11f,1f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black2, new Vector3(11f,-1f,0),Quaternion.Euler(0, 0, 90));
            timea=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(white3, new Vector3(10f,1f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black3, new Vector3(10f,-1f,0),Quaternion.Euler(0, 0, 90));
            timea=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(redup, new Vector3(10f,1f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(reddown, new Vector3(10f,-1f,0),Quaternion.Euler(0, 0, 90));
            timea=0.7f+Random.Range(0f,2f);
            }
            time1=0;
        }
        if(time2>timeb)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(white1, new Vector3(10.5f,2.5f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black1, new Vector3(10.5f,-2.5f,0), Quaternion.Euler(0, 0, 90));
            timeb=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(white2, new Vector3(11f,2.5f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black2, new Vector3(11f,-2.5f,0),Quaternion.Euler(0, 0, 90));
            timeb=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(white3, new Vector3(10f,2.5f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black3, new Vector3(10f,-2.5f,0), Quaternion.Euler(0, 0, 90));
            timeb=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(redup, new Vector3(10f,2.5f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(reddown, new Vector3(10f,-2.5f,0), Quaternion.Euler(0, 0, 90));
            timeb=0.7f+Random.Range(0f,2f);
            }
            time2=0;
        }
        if(time3>timec)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(white1, new Vector3(10.5f,4f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(black1, new Vector3(10.5f,-4f,0), Quaternion.Euler(0, 0, 90));
            timec=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(white2, new Vector3(11f,4f,0),Quaternion.Euler(0, 0, 90));
            Instantiate(black2, new Vector3(11f,-4f,0), Quaternion.Euler(0, 0, 90));
            timec=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(white3, new Vector3(10f,4f,0),Quaternion.Euler(0, 0, 90));
            Instantiate(black3, new Vector3(10f,-4f,0),Quaternion.Euler(0, 0, 90));
            timec=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(redup, new Vector3(10.5f,4f,0), Quaternion.Euler(0, 0, 90));
            Instantiate(reddown, new Vector3(10.5f,-4f,0), Quaternion.Euler(0, 0, 90));
            timec=0.7f+Random.Range(0f,2f);
            }
            time3=0;
        }
    }
    public void FixedUpdate()
    {
        
        // a=a+(0.03f/a);
        if(t>=5)
        {
            y=Random.Range(0,4);
            if(y==0)
            a=5f;
            else if(y==1)
            a=7f;
            else if(y==2)
            a=9f;
            else if(y==3)
            a=11f;

            t=0f;
        }    
        t=t+Time.deltaTime;
    }
}  
//(Scoreside.valueup)*
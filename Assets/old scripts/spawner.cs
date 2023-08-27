using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject square1; 
    public GameObject square2;
    public GameObject square3;
    public GameObject red;
    public int height = 2;
    public float width ;
  //  private float val = 1.56f;
    public float time1 =0f;
    public float time2 =0f;
    public float time3 =0f;
    private Vector3 location;
    private  float timea=1f,timeb=0f,timec=0f;
    private int x;
    public static float a=8f;
    void Start()
    {
        
        a=8f;
    }
  /*  void FixedUpdate() {
     if (Input.touchCount > 0)
        {
            generateblock();
        }
        
    }*/
     void Update()
    {
        time1=time1+ Time.deltaTime;
        time2=time2+ Time.deltaTime;
        time3=time3+ Time.deltaTime;
      
  //  {   Random.Range(-10.0f, 10.0f)
        if(time1>timea)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(square1, new Vector3(-1.56f,10.5f,0), Quaternion.identity);
            timea=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(square2, new Vector3(-1.56f,11f,0), Quaternion.identity);
            timea=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(square3, new Vector3(-1.56f,10f,0), Quaternion.identity);
            timea=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(red, new Vector3(-1.56f,11f,0), Quaternion.identity);
            timea=1f+Random.Range(0f,2f);
            }
            time1=0;
        }
        if(time2>timeb)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(square1, new Vector3(0f,10.5f,0), Quaternion.identity);
            timeb=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(square2, new Vector3(0f,11f,0), Quaternion.identity);
            timeb=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(square3, new Vector3(0f,10f,0), Quaternion.identity);
            timeb=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(red, new Vector3(0f,11f,0), Quaternion.identity);
            timeb=1f+Random.Range(0f,2f);
            }
            time2=0;
        }
        if(time3>timec)
        {
            x=Random.Range(0,4);
            if(x==0)
            {
            Instantiate(square1, new Vector3(1.56f,10.5f,0), Quaternion.identity);
            timec=0.7f+Random.Range(0f,2f);
            }
            if(x==1)
            {
            Instantiate(square2, new Vector3(1.56f,11f,0), Quaternion.identity);
            timec=1f+Random.Range(0f,2f);
            }
            if(x==2)
            {
            Instantiate(square3, new Vector3(1.56f,10f,0), Quaternion.identity);
            timec=0.5f+Random.Range(0f,2f);
            }
            if(x==3)
            {
            Instantiate(red, new Vector3(1.56f,11f,0), Quaternion.identity);
            timec=1f+Random.Range(0f,2f);
            }
            time3=0;
        }
    }
    public void FixedUpdate()
    {
        a=a+(0.01f/a);
    }
}    

/*void generateblock()
{
    float timea=1f,timeb=0f,timec=0f;
  //  {   Random.Range(-10.0f, 10.0f)
  if(time1>timea)
  {
            int x=Random.Range(0,3);
            if(x==0)
            {
                Instantiate(square1, new Vector3(-1.56f,10.5f,0), Quaternion.identity);
            }
            if(x==1)
            {
            Instantiate(square2, new Vector3(-1.56f,11f,0), Quaternion.identity);
            }
            if(x==2)
            {
            Instantiate(square3, new Vector3(-1.56f,10f,0), Quaternion.identity);
            }
            time1=0;
  }
          //  Instantiate(square1, new Vector3(-1.56f,10.5f,0), Quaternion.identity);

         //   Instantiate(square2, new Vector3(0,11f,0), Quaternion.identity);

          //  Instantiate(square3, new Vector3(1.56f,10f,0), Quaternion.identity);

}
}*/

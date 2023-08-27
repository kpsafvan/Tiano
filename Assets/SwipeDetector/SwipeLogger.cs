using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class SwipeLogger : MonoBehaviour
{
    public GameObject pause;
  // public static GameObject pause2 = pause.GameObject;
    public static bool p=true;

   // public static GameObject Pause2 { get => pause2; set => pause2 = value; }

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }
    private void Start() {
     p=true;   
    }
    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        Debug.Log("Swipe in Direction: " + data.Direction);
        string a =data.Direction.ToString();
        if(a=="Right"&&SceneManager.GetActiveScene().name=="Single")
        {
            if(p)
            {
                pause.SetActive(true);
                Time.timeScale=0;  
                p=false;
            }
            else
            {
                pause.SetActive(false);
                Time.timeScale=1;  
                p=true; 
                SceneManager.LoadScene("START FINAL");       
            }
        }
        else if(a=="Left"&&SceneManager.GetActiveScene().name=="Single"&&p==false)
        {
            pause.SetActive(false);
            Time.timeScale=1;  
            p=true; 

        }
    }

}
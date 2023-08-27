using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class life : MonoBehaviour
{
     public Text li;
    public static int lives =0;
    void Start()
    {
          lives=3;    
    }
 
    void Update()
    {
        li.text=lives.ToString();

        if(lives<0)
        {
            Debug.Log("YOU LOOSE SCORE IS:"+Score.value);
            lives=0;
            PlayerPrefs.SetInt("SCORE",Score.value);
            Debug.Log("Sccore"+Score.value);
            Debug.Log("high score from pf"+PlayerPrefs.GetInt("HS",0));
            
           // int a=;
            if(PlayerPrefs.GetInt("HS",0)<Score.value)
            {
                PlayerPrefs.SetInt("HS",Score.value);
                SceneManager.LoadScene("HIGHSCORE");
            }
            else
            {
                SceneManager.LoadScene("LOSE");
            }
        }
    }
}

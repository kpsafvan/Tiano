using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class high : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
       Scene scene = SceneManager.GetActiveScene();
        if(scene.name=="LOSE")
        {
            score.text=PlayerPrefs.GetInt("SCORE").ToString();
        }   
        else
        {
             score.text=PlayerPrefs.GetInt("HS").ToString();
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

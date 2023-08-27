using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoreside : MonoBehaviour
{
    // Start is called before the first frame update
    public static int valueup = 0;
    public static int valuedown = 0;
  
    public Text scoreup;
    public Text scoredown;
    // Update is called once per frame
    private void Start() {
            valueup=0;
            valuedown=0;    
    }
    void Update()
    {
        scoreup.text=valueup.ToString();
        scoredown.text=valuedown.ToString();
      /*  if(valueup>=50)
        {
            SceneManager.LoadScene("UPWINS");
            Debug.Log("UPWINS");
        }
        if(valuedown>=50)
        {
            Debug.Log("DOWNWINS");
            SceneManager.LoadScene("DOWNWINS");
        }*/
        if(valueup-valuedown>=10)
        {
            SceneManager.LoadScene("UPWINS");
            Debug.Log("UPWINS");
        }
        if(valuedown-valueup>=10)
        {
            Debug.Log("DOWNWINS");
            SceneManager.LoadScene("DOWNWINS");
        }
        
    }
 
}
 
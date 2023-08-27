using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public int abcd;
   // public Text name;
    public void Singleplayer()
    {
     SceneManager.LoadScene("Single");
     //  ad="Single";
    //    name.text="1 PLAYER";
    }
    public void Doubleplayer()
    {
        SceneManager.LoadScene("Double");
      //   ad="Double";
       //  name.text="2 PLAYER";
    }
    public void side()
    {
        SceneManager.LoadScene("Side D");
    //    ad="Side D";
     //   name.text="SIDE 2  PLAYER";
    }
    public void choice()
    {
        SceneManager.LoadScene("Choice");
     //   ad="Choice";
       // name.text="SIDE 2  PLAYER";
    }
    public void quit()
    {
        Application.Quit();
    }
    public void options()
    {
        SceneManager.LoadScene("Options");
     //   ad="Choice";
       // name.text="SIDE 2  PLAYER";
    }
     public void startscene()
    {
        SceneManager.LoadScene("START FINAL");
        Debug.Log("SAD");
     //   ad="Choice";
       // name.text="SIDE 2  PLAYER";
    }
  //  public GameObject pause;
  /*  public void continu()
    {
        Time.timeScale=1;
        SwipeLogger.p=true;
        pause.SetActive(false);

    }*/
}

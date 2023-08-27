using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int value = 0;
    public Text score;
  void Start() {
       value=0;
   }
    void Update()
    {
        score.text=value.ToString();
        
    }
}

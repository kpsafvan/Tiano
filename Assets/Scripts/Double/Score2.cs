using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score2 : MonoBehaviour
{
    public static int valueup = 0;
    public static int valuedown = 0;
    public Text scoreup;
    public Text scoredown;
    // Update is called once per frame
    void Update()
    {
        scoreup.text=valueup.ToString();
        scoredown.text=valuedown.ToString();
    }
}

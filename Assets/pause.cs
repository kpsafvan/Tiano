using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausee;
    void Start()
    {
        if(SceneManager.GetActiveScene().name=="Single")
        {
            Debug.Log("asd  dfsa");
        }
        else
        {
            
            Debug.Log("asddfsa");
            pausee.SetActive(false);
          //  gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

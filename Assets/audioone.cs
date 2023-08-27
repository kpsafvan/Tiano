using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioone : MonoBehaviour
{
    // Start is called before the first frame update
    private float time = 0f;
    public int audioup=0;
    public int audiodown=0;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        // time+= Time.deltaTime;
        // if(time>1){
        //     time=0;
        //     GetComponent<AudioSource>().Play();
        // }

        if(Scoreside.valueup>audioup){
            GetComponent<AudioSource>().Play();
            audioup=Scoreside.valueup;
        }

        if(Scoreside.valuedown>audiodown){
            GetComponent<AudioSource>().Play();
            audiodown=Scoreside.valuedown;
        }
    }
}

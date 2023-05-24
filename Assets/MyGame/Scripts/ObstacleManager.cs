using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ObstacleManager : MonoBehaviour
{
    public bool objCorrected = false;
    public AudioSource objAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objCorrected)
        {
            objAudio.Stop();
        }
    }
}

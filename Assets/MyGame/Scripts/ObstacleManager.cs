using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ObstacleManager : MonoBehaviour
{
    public bool objCorrected = false;
    public AudioSource constantAudio;
    public AudioSource switchAudio;
    public GameObject lightLamp;
    public int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        
        
        
        if (gameObject.tag == "LightSwitch" && objCorrected == false)
        {
            constantAudio.Stop();
            switchAudio.Play();
            points = points + 1;
            lightLamp.SetActive(false);
            objCorrected = true;
        }
        if (gameObject.tag == "Radio" && objCorrected == false)
        {
            objCorrected = true;
            constantAudio.Stop();
            points = points + 1;
        }
        if (gameObject.tag == "Cookpot" && objCorrected == false)
        {
            objCorrected = true;
            constantAudio.Stop();
            points = points + 1;
        }
       
    }

    public int PointsCounter()
    {
        if (true)
        {

        }
        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (objCorrected)
        {
            constantAudio.Stop();
        }
    }
}

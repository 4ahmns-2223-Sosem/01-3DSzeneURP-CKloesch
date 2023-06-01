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
    private int points;
    public GameManagerScript gMS;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {

        
        
        if (gameObject.tag == "LightSwitch" && objCorrected == false)
        {
            gMS.correctedObjs[0] = true;

            constantAudio.Stop();
            switchAudio.Play();
            

            lightLamp.SetActive(false);
            objCorrected = true;
        }
        if (gameObject.tag == "Radio" && objCorrected == false)
        {
            gMS.correctedObjs[1] = true;
            objCorrected = true;
            constantAudio.Stop();
            
            
        }
        if (gameObject.tag == "Cookpot" && objCorrected == false)
        {
            gMS.correctedObjs[2] = true;
            objCorrected = true;
            constantAudio.Stop();
            
        }
        if (gameObject.tag == "Window" && objCorrected == false)
        {
            gMS.correctedObjs[3] = true;
            objCorrected = true;
            constantAudio.Stop();
            
        }
       

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

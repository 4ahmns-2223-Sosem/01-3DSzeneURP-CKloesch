using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int points;
    public bool[] correctedObjs = new bool[4];
    public FPSController fpscontrl;
    public Text bravoText;
    
    void Start()
    {
        
        
    }

    void Update()
    {
        
        if (correctedObjs[0] == true)
        {
            Counter();
            correctedObjs[0] = false;
        }
        if (correctedObjs[1] == true)
        {
            Counter();
            correctedObjs[1] = false;
        }
        if (correctedObjs[2] == true)
        {
            Counter();
            correctedObjs[2] = false;
        }
        if (correctedObjs[3] == true)
        {
            Counter();
            correctedObjs[3] = false;
        }
        if (points == 4)
        {
            fpscontrl.canMove = false;
            bravoText.gameObject.SetActive(true);
        }
    }

    public int Counter()
    {
        points++;
        return points;
    }
   
    
}

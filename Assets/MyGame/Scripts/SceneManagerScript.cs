using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    public void OnInfoButtonClick()
    {
        SceneManager.LoadScene("InfoWall");
    }
    
}
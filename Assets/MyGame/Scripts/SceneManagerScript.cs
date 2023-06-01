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

    
    public void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("jetzt würde ich zur InfoWall springen");
    }
    
}

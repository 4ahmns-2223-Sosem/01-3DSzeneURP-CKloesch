using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    public GameObject window;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        
        window.transform.Rotate(0, 0, 0);
        window.transform.position = new Vector3(22.48f, 14.85f, 12.2f);
        window.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

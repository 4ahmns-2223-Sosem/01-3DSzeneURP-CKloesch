using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookpotScript : MonoBehaviour
{
    public GameObject deckel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        deckel.transform.position = new Vector3(14.65f, 12.33f, -30.423f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

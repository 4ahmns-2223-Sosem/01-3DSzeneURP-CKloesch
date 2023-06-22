using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawner : MonoBehaviour
{
    public int bookCounter = 0;
    public GameObject book;
    public GameObject parent;
 
    void Start()
    {
        
        CreateCubes();
    }

    private void CreateCubes()
    {
        while (bookCounter < 15)
        {
            
            GameObject cube = Instantiate(book, Vector3.zero, Quaternion.identity);
            GameObject cube2 = Instantiate(book, Vector3.zero, Quaternion.identity);
            GameObject cube3 = Instantiate(book, Vector3.zero, Quaternion.identity);
            GameObject cube4 = Instantiate(book, Vector3.zero, Quaternion.identity);
            GameObject cube5 = Instantiate(book, Vector3.zero, Quaternion.identity);

            cube.gameObject.transform.SetParent(parent.transform);
            cube2.gameObject.transform.SetParent(parent.transform);
            cube3.gameObject.transform.SetParent(parent.transform);
            cube4.gameObject.transform.SetParent(parent.transform);
            cube5.gameObject.transform.SetParent(parent.transform);


            cube.transform.position = new Vector3(-19.03f,  16.7f ,3.32f * Random.Range(3, 10) );
            cube2.transform.position = new Vector3(-19.03f, 12.47f, 3.32f * Random.Range(2, 12));
            cube3.transform.position = new Vector3(-19.03f, 7.71f, 3.32f * Random.Range(1, 11));
            cube4.transform.position = new Vector3(-19.03f, 2.29f, 3.32f * Random.Range(1, 14));
            cube5.transform.position = new Vector3(-19.03f, 21.14f, 3.32f * Random.Range(1, 8));


            Color randomColor = new Color(Random.value, Random.value, Random.value);
            cube.GetComponent<Renderer>().material.color = randomColor;
            cube2.GetComponent<Renderer>().material.color = randomColor;
            cube3.GetComponent<Renderer>().material.color = randomColor;
            cube4.GetComponent<Renderer>().material.color = randomColor;
            cube5.GetComponent<Renderer>().material.color = randomColor;


            bookCounter++;
            Debug.Log(bookCounter);
           
        } 
        
    }
    
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TobiScript : MonoBehaviour
{

   
    // Use this for initialization
    void Start()
    {
        Debug.Log("super fun!");

        
        


    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("it is green!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }

        




    }
}

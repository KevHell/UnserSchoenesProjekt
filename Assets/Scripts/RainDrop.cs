using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    float size = 1f;
    float speed = 1;
    Vector3 newScale;

    float random;
    float timeChange = 0.5f;
    // Use this for initialization
    void Start()
    {

        newScale = transform.localScale;

        newScale.x = Random.Range(0, 1f);
        newScale.y = Random.Range(0, 1f);
        newScale.z = Random.Range(0, 1f);

        Invoke("Destroy", 3f);
    }

    private void Update()
    {
        //GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        
        if(Time.time - timeChange > 0.5)
        {
            random = Random.value;
            timeChange = Time.time;
        }

        newScale.z = Mathf.PingPong(Time.time * speed * random, size);
        newScale.y = Mathf.PingPong(Time.time * speed * random, size);
        newScale.x = Mathf.PingPong(Time.time * speed * random, size);
        

        transform.localScale = newScale;
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}

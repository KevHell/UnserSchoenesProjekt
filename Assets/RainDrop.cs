using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Vector3 newScale;
    // Use this for initialization
    void Start () {
       
        newScale = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));

        newScale.z = Mathf.PingPong(Time.time, 1.5f);
        newScale.y = Mathf.PingPong(Time.time, 1.5f);
        newScale.x = Mathf.PingPong(Time.time, 1.5f);
    }
}

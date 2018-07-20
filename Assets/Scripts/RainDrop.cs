using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{

    Vector3 newScale;
    // Use this for initialization
    void Start()
    {

        newScale = transform.localScale;

        Invoke("Destroy", 3f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}

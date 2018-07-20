using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float beatsPerMinute;

    Vector3 newScale;

    public float minPulseSize = 1f;
    public float maxPulseSize = 1.5f;

    float tempo;

    bool isIncreasing = true;
    bool cycleComplete = false;

    float lastCalledPulse = 0;

    // Use this for initialization
    void Start()
    {
        newScale = transform.localScale;

        tempo = 60 / beatsPerMinute;
        lastCalledPulse = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cycleComplete)
            PulseSize();

        if (Time.time - lastCalledPulse > tempo)
        {
            GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            lastCalledPulse = Time.time;
            cycleComplete = false;
        }
    }

    void PulseSize()
    {
        Debug.Log("pulse");
        if (Mathf.Abs(maxPulseSize - newScale.x) < 0.01f)//|| Mathf.Abs(maxPulseSize - newScale.y) < 0.1f)
        {
            isIncreasing = false;
        }
        else if (Mathf.Abs(minPulseSize - newScale.x) < 0.01f)// || Mathf.Abs(minPulseSize - newScale.y) < 0.1f)
        {
            isIncreasing = true;
            cycleComplete = true;
        }

        if (isIncreasing)
        {
            Debug.Log("increase");
            newScale.x = Mathf.Lerp(newScale.x, maxPulseSize, 0.2f);
            newScale.y = Mathf.Lerp(newScale.y, maxPulseSize, 0.2f);
            newScale.z = Mathf.Lerp(newScale.y, maxPulseSize, 0.2f);
        }
        else
        {
            Debug.Log("decrease");
            newScale.x = Mathf.Lerp(newScale.x, minPulseSize, 0.2f);
            newScale.y = Mathf.Lerp(newScale.y, minPulseSize, 0.2f);
            newScale.z = Mathf.Lerp(newScale.y, minPulseSize, 0.2f);
        }


        transform.localScale = newScale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // VARIABLES
    public float playerSpeed = 5f;
    public float playerRotationSpeed = 5f;

    Vector3 newScale;

    // TRANSFORMS
    Transform playerTransform;

    // OTHERS
    Rigidbody playerRigidbody;
    Vector3 playerVelocity;


    void Start()
    {
        playerTransform = GetComponent<Transform>();
        playerRigidbody = GetComponent<Rigidbody>();

        newScale = transform.localScale;
    }


    void Update()
    {
        // ROTATE LEFT
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            playerTransform.Rotate(0, 0, playerRotationSpeed);
        }
        // ROTATE RIGHT
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0, 0, playerRotationSpeed * -1);
        }
        // GO FORWARD
        float vertical = Input.GetAxis("Vertical");
        float speed = playerSpeed;

        if (vertical < 0)
        {
            speed *= 0.5f;
        }

        playerVelocity = playerTransform.up * vertical * speed;
        playerRigidbody.velocity = playerVelocity;

        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));

        newScale.x = Mathf.PingPong(Time.time, 1.5f);
        transform.localScale = newScale;
    }
}

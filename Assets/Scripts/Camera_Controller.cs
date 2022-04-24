using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public GameObject player;
    Vector3 velocity = Vector3.zero;
    float smoothness = 0.25f;

    private void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(
                player.transform.position.x, transform.position.y, transform.position.z),
                ref velocity, smoothness);
        if(transform.position.x < -37.8f)
        {
            transform.position = new Vector3(-37.8f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 37.8f)
        {
            transform.position = new Vector3(37.8f, transform.position.y, transform.position.z);
        }
    }
}

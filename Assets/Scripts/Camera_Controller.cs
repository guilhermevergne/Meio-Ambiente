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
        
        if (player.transform.localPosition.x > -37.8f && player.transform.localPosition.x < 37.8f)
        {
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                player.transform.localPosition.x, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }



        
        if (player.transform.localPosition.x < -37.8f)
        {
            //transform.localPosition = new Vector3(-37.8f, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                -37.8f, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }
        if (player.transform.localPosition.x > 37.8f)
        {
            //transform.localPosition = new Vector3(37.8f, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                37.8f, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }
    }
}

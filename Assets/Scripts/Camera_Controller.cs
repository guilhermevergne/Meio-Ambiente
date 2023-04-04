using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public GameObject player;
    Vector3 velocity = Vector3.zero;
    float smoothness = 0.25f;
    public float limiteEsq;
    public float limiteDir;

    private void FixedUpdate()
    {
        
        if (player.transform.localPosition.x > limiteEsq && player.transform.localPosition.x < limiteDir)
        {
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                player.transform.localPosition.x, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }



        
        if (player.transform.localPosition.x < limiteEsq)
        {
            //transform.localPosition = new Vector3(-37.8f, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                limiteEsq, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }
        if (player.transform.localPosition.x > limiteDir)
        {
            //transform.localPosition = new Vector3(37.8f, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(
                limiteDir, transform.localPosition.y, transform.localPosition.z),
                ref velocity, smoothness);
        }
    }
}

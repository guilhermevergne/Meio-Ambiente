using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public GameObject player;
    Vector3 velocity = Vector3.zero;
    float smoothness = 0.25f;
    int n = 0;
    bool done = false;


    private void FixedUpdate()
    {
        if (n > 10 && !done)
        {
            string charTag = PlayerPrefs.GetString("gender");
            charTag += PlayerPrefs.GetString("color");
            charTag += PlayerPrefs.GetString("hair");
            player = GameObject.Find(charTag+"(Clone)");
            print(charTag);
            done = true;
            n = -1;
        }
        else if (n >= 0)
        {
            n++;
        }
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

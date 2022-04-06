using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Character : MonoBehaviour
{
    public float speedX = 10;
    public float speedY = 5;
    Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speedX, Input.GetAxisRaw("Vertical") * speedY);
    }

}

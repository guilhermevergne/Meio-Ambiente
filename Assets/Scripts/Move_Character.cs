using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Character : MonoBehaviour
{
    public float speedX = 10;
    public float speedY = 5;
    public int type;
    Rigidbody2D rig;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        if (type == 0)
        {
            rig.velocity = new Vector2(hor * speedX, ver * speedY);
            if (hor != 0)
            {
                transform.localScale = new Vector3(-0.3f*hor, transform.localScale.y, transform.localScale.z);
            }

        }
        else if(type == 1)
        {
            transform.localPosition = new Vector3(0, 0, 0);
            if (hor != 0 || ver != 0)
            {
                animator.SetBool("walking", true);
            }
            else
            {
                animator.SetBool("walking", false);
            }
        }
    }

}

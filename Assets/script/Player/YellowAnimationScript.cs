using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowAnimationScript : MonoBehaviour
{
    float speed = 0.0f;
    float jump = 0.0f;
    float VX = 15f;
    float VY = 10f;//13f;

    Animator AAA;
    Rigidbody2D RRR;
    //Scale, Edb/|\db3
    Vector3 temp;
    // Start is called before the first frame update
    private void Awake()
    {
        RRR = GetComponent<Rigidbody2D>();
        AAA = GetComponent<Animator>();
        RRR.freezeRotation = true;
    }
    void Start()
    {
        temp = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime * VX;
        jump = Input.GetAxisRaw("Vertical") * Time.deltaTime * VY;
        if (jump > 0)
        {
            transform.position += new Vector3(speed, jump, 0f);
            AAA.SetBool("LogicalJump", true);
            AAA.SetBool("LogicalMove", false);
            if (speed > 0)
            {
                temp.x = 1;
            }
            else if (speed < 0)
            {
                temp.x = -1;
            }
        }
        else if (jump == 0)
        {
            transform.position += new Vector3(speed, 0, 0f);
            if (speed > 0)
            {
                AAA.SetBool("LogicalJump", false);
                AAA.SetBool("LogicalMove", true);
                temp.x = 1;
                //transform.localScale = temp;
            }
            else if (speed < 0)
            {
                AAA.SetBool("LogicalJump", false);
                AAA.SetBool("LogicalMove", true);
                //Scale, Edb/|\db3
                temp.x = -1;
                //transform.localScale = temp;
            }
            else
            {
                AAA.SetBool("LogicalMove", false);
                AAA.SetBool("LogicalJump", false);

            }

        }
        transform.localScale = temp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int score = 0;
    public int health = 5;
    //Movement, <-[]->
    float GY = -2.635369f;
    [SerializeField]
    Rigidbody2D RRR;

    //Scale, Edb/|\db3
    Vector3 temp;
    //IsGround

    private void Awake()
    {
        RRR = GetComponent<Rigidbody2D>();
        RRR.freezeRotation = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        temp = transform.localScale;
    }


    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GreenZombie"
            && transform.position.y <= GY + 2)
        {
            health -= 1;
            Debug.Log("HEALTH: " + health);
            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.tag == "GreenZombie"
            && (transform.position.y > GY + 2))
        {
            Destroy(collision.gameObject);
            score += 1;
            Debug.Log("SCORE: " + score);
        }
        //
        else if (collision.gameObject.tag == "Ghosting"
            && transform.position.y <= GY + 1)
        {
            Destroy(collision.gameObject);
            score += 1;
            Debug.Log("SCORE: " + score);
        }
        else if (collision.gameObject.tag == "Ghosting"
            && (transform.position.y > GY + 1))
        {
            health -= 1;
            Debug.Log("HEALTH: " + health);
            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}

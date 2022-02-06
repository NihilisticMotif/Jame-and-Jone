using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    Transform player;
    Rigidbody2D rb;
    Vector3 Move;
    Vector3 temp;
    Vector3 locate;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();
        temp = transform.localScale;
    }
    void Update()
    {
        if (player != null)
        {
            float direction = player.position.x - transform.position.x;
            locate = transform.position;
            locate.x += direction * Time.deltaTime;
            transform.position = locate;

            if (direction >= 0 && transform.position.y > -10)
            {
                temp.x = 1;
                if (direction < 3)
                {
                    locate = transform.position;
                    locate.x += 10 * Time.deltaTime;
                    transform.position = locate;
                }
            }
            else if (direction <= 0 && transform.position.y > -10)
            {
                temp.x = -1;
                if (direction > -3)
                {
                    locate = transform.position;
                    locate.x += -10 * Time.deltaTime;
                    transform.position = locate;
                }
            }
            else
            {
                Destroy(gameObject);
            }
            transform.localScale = temp;
        }
    }
}

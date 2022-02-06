using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Transform Move;  
    Vector3 temp;

    Rigidbody2D myBody;


    // Start is called before the first frame update
    private void Start()
    {
        Move = GetComponent<Transform>();
        Move.position = new Vector2(transform.position.x, transform.position.y);
        temp = transform.localScale;
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float PosX = transform.position.x;
        PosX += Time.deltaTime * Mathf.Sin(Time.time)*10;
        Move.position = new Vector2(PosX, transform.position.y);
        if (Mathf.Sin(Time.time) >= 0&& transform.position.y>-10)
        {
            temp.x = 1;
        }
        else if (Mathf.Sin(Time.time) <= 0 && transform.position.y > -10)
        {
            temp.x = -1;
        }
        else
        {
            Destroy(gameObject);
        }
        transform.localScale = temp;
    }
}

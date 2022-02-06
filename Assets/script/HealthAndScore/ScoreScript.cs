using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //public GameObject ant;
    private PlayerScript ScoreNumber;
    private Text title;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.gameObject.GetComponent<Text>().text = "SCORE: "+ScoreNumber.score.ToString();
        if (ScoreNumber.score > 100)
        {
            transform.gameObject.GetComponent<Text>().text = "SCORE:" + ScoreNumber.score.ToString();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart5 : MonoBehaviour
{
    private PlayerScript HealthNumber;
    [SerializeField] private Transform levelPart_1;
    //[SerializeField] private Transform levelPart_2;
    public GameObject[] GameArray = new GameObject[5];
    int fivelife = 5;

    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            var clone00 = Instantiate(
                levelPart_1,
                new Vector3(-2000 + i * 1000, 0),
                Quaternion.identity
                );
            clone00.transform.SetParent(this.transform, false);
            GameArray[i] = clone00.gameObject;
        }
    }
    void Start()
    {
        //ScoreNumber = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        HealthNumber = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //HealthNumber.health
        if (HealthNumber.health<fivelife)
        {
            Destroy(GameArray[(fivelife-1)]);
            fivelife -= 1;
        }
    }
}
/*
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
*/
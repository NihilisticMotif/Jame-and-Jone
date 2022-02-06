using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StopGame : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;
    //[SerializeField] private Transform levelPart_2;
    public GameObject[] GameArray = new GameObject[1];
    bool pause = true;
    public void StopGameGame()
    {
        string clickedname = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (clickedname == "BackButton" || clickedname == "No0")
        {
            if (pause)
            {
                Time.timeScale = 0;
                var clone00 = Instantiate(
                    levelPart_1,
                    new Vector3(0, 0),
                    Quaternion.identity
                );
                clone00.transform.SetParent(this.transform, false);
                GameArray[0] = clone00.gameObject;
                pause = false;
            }
            else
            {
                Time.timeScale = 1;
                Destroy(GameArray[0]);
                pause = true;
            }
        }
        else if (clickedname == "Yes0")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("MainMain");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManuController : MonoBehaviour
{
    [SerializeField] private GameObject[] YellowBlue;
    public GameObject[] GameArray = new GameObject[1];
    public void PlayGame()
    {
        string clickedname = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        //SceneManager.LoadScene("JumperGame");
        //Debug.Log(clickedname);
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            SceneManager.LoadScene("JumperGame");
            if (clickedname == "Yellow")
            {
                var yellowPlayer = Instantiate(YellowBlue[0], new Vector3(0, 0), Quaternion.identity);
                DontDestroyOnLoad(yellowPlayer);
            }
            else if (clickedname == "Blue")
            {
                var yellowPlayer = Instantiate(YellowBlue[1], new Vector3(0, 0), Quaternion.identity);
                DontDestroyOnLoad(yellowPlayer);
            }
            Time.timeScale = 1;
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("JumperGame");
            if (clickedname == "Yellow")
            {
                var yellowPlayer = Instantiate(YellowBlue[0], new Vector3(0, 0), Quaternion.identity);
                DontDestroyOnLoad(yellowPlayer);
            }
            else if (clickedname == "Blue")
            {
                var yellowPlayer = Instantiate(YellowBlue[1], new Vector3(0, 0), Quaternion.identity);
                DontDestroyOnLoad(yellowPlayer);
            }
            Time.timeScale = 1;
        }
    }
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Debug.Log("Blue");
        //MainManuController.instance.YellowBlue = clickedname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
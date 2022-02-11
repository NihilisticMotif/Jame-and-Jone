using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class exitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame()
    {
        string clickedname = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (clickedname == "Exit")
        {
            Application.Quit();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

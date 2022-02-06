using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGreatestShow : MonoBehaviour
{
    int[] sameNum = new int[2];
    [SerializeField] private Transform levelPart_1;
    GameObject[,] GameArray = new GameObject[2, 3];
    Transform Tran;
    Vector3 VecX;
    Vector3 VecY;
    bool bol = true;
    bool Booly = true;

    [SerializeField] private Transform Zom0;
    [SerializeField] private Transform Zom1;
    [SerializeField] private Transform Ghost;
    // Start is called before the first frame update
    private void Awake()
    {
        var clone00=Instantiate(
            levelPart_1,
            new Vector3(0, -5),
            Quaternion.identity
            );
        var clone01 = Instantiate(
            levelPart_1,
            new Vector3(22.7f, -5),
            Quaternion.identity
            );
        var clone02 = Instantiate(
            levelPart_1,
            new Vector3(-22.7f, -5),
            Quaternion.identity
            );
        GameArray[0,0] = clone00.gameObject;
        GameArray[0,1] = clone01.gameObject;
        GameArray[0,2] = clone02.gameObject;

    }
    void Start()
    {
        Tran = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Tran != null) {
        VecX = transform.position;
        VecX.x = Tran.position.x;
        transform.position = VecX;
            int someInt = (int)System.Math.Round(VecX.x / 11.35);
        if (bol)
        {
            sameNum[0] = someInt;
            bol = false;
        }
        else
        {
            sameNum[1] = someInt;
            bol = true;
        }

            if (sameNum[0] != sameNum[1])
            {
                if (Booly)
                {
                    var clone10 = Instantiate(
                        levelPart_1,
                        new Vector3((VecX.x - 22.7f), -5),
                        Quaternion.identity
                        );
                    var clone11 = Instantiate(
                        levelPart_1,
                        new Vector3(VecX.x, -5),
                        Quaternion.identity
                        );
                    var clone12 = Instantiate(
                        levelPart_1,
                        new Vector3((VecX.x + 22.7f), -5),
                        Quaternion.identity
                        );
                    Destroy(GameArray[0, 0], 0.0f);
                    Destroy(GameArray[0, 1], 0.0f);
                    Destroy(GameArray[0, 2], 0.0f);
                    GameArray[1, 0] = clone10.gameObject;
                    GameArray[1, 1] = clone11.gameObject;
                    GameArray[1, 2] = clone12.gameObject;
                    Booly = false;
                }
                else
                {

                    var clone00 = Instantiate(
                        levelPart_1,
                        new Vector3((VecX.x - 22.7f), -5),
                        Quaternion.identity
                        );
                    var clone01 = Instantiate(
                        levelPart_1,
                        new Vector3(VecX.x, -5),
                        Quaternion.identity
                        );
                    var clone02 = Instantiate(
                        levelPart_1,
                        new Vector3((VecX.x + 22.7f), -5),
                        Quaternion.identity
                        );
                    Destroy(GameArray[1, 0], 0.0f);
                    Destroy(GameArray[1, 1], 0.0f);
                    Destroy(GameArray[1, 2], 0.0f);
                    GameArray[0, 0] = clone00.gameObject;
                    GameArray[0, 1] = clone01.gameObject;
                    GameArray[0, 2] = clone02.gameObject;
                    Booly = true;
                }


                int Zom0L = Random.Range(-1, 4);
                int Zom1L = Random.Range(-1, 4);
                int GhostL = Random.Range(-1, 4);
                //float FFount=Random.Range(??f,??f);
                for (int i = 0; i <= Zom0L; i++)
                {
                    Instantiate(
                        Zom0,
                        new Vector3((VecX.x + Random.Range(-10.0f, 10.0f)), -2.5f),
                        Quaternion.identity
                );
                }
                for (int i = 0; i <= Zom1L; i++)
                {
                    Instantiate(
                        Zom1,
                        new Vector3((VecX.x + Random.Range(-10.0f, 10.0f)), -2.5f),
                        Quaternion.identity
                );
                }
                for (int i = 0; i <= GhostL; i++)
                {
                    Instantiate(
                        Ghost,
                        new Vector3((VecX.x + Random.Range(-10.0f, 10.0f)), -2.5f),
                        Quaternion.identity
                );
                }
            }
            /*
             How to delete instantiated game object? https://answers.unity.com/questions/534314/how-to-delete-instantiated-gameobject.html
             How to create 2d array? https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
             */
        }
    }
}

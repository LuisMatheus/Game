using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject tile;
    public GameObject player1;
    public GameObject player2;
    public int size;
    public int maxHeight = 1;
    public float elevationCoeficient = 1.0f;


    //@ TODO : BETTER EQUATION
    private int GetYAxis()
    {
        return Mathf.CeilToInt( Random.Range(1, maxHeight) / elevationCoeficient );
    }

    void Start()
    {
        int y = GetYAxis();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Instantiate(tile,new Vector3(i,y,j),Quaternion.identity);
                if (i == 0 && j == 0)
                {
                    Instantiate(player1, new Vector3(i, y+1, j), Quaternion.identity);
                }
                y = GetYAxis();
            }
        }

        
        Instantiate(player2, new Vector3(size-1, y+1, size-1), Quaternion.identity);

    }

}

using System;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject g;

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = Convert.ToString(g.GetComponent<PlayerMove>().move);
    }
}

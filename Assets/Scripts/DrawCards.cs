using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

    public GameObject Card;
    public GameObject Hand;

    public void OnClick() {
        for (var i = 0; i < 1; i ++){
            GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(Hand.transform, false);
        }
        
    }
}

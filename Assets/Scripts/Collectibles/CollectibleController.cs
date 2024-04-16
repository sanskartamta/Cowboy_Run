using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleController : MonoBehaviour
{
    public static int CoinCount;
    public GameObject coinCountDisplay;
    public GameObject coinendDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + CoinCount;
        coinendDisplay.GetComponent<TextMeshProUGUI>().text = "" + CoinCount;
    }
}

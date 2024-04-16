using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource CoinSFX;
    private void OnTriggerEnter(Collider other)
    {
        CoinSFX.Play();
        this.gameObject.SetActive(false);
        CollectibleController.CoinCount += 1;
    }
}

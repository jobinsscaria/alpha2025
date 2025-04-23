using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int Gem = 0;

    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Gem")
        {
            Gem++;
            coinText.text = "Gem Count: " + Gem.ToString();
            Debug.Log(Gem);
            Destroy(other.gameObject);
        }
    }
}

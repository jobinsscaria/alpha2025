using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollector : MonoBehaviour
{
    public CountManager countManager; // Reference to CountManager

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (countManager != null)
            {
                countManager.IncrementCount();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollector : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) { // Ensure avatar has "Player" tag
            Destroy(gameObject);
            // Add score update logic here
        }
    }
}
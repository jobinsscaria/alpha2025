using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ICollectible {
    void Collect();
}

public class Gem : MonoBehaviour, ICollectible {
    public void Collect() {
        Destroy(gameObject);
    }
}

public class AvatarCollision : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        ICollectible collectible = other.GetComponent<ICollectible>();
        collectible?.Collect();
    }
}

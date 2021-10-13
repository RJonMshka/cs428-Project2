using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    public AudioSource ballHitSound;

    void OnCollisionEnter (Collision collision) {
        Debug.Log($"{gameObject.name} is colliding with {collision.collider.name}");
        if (!ballHitSound.isPlaying && collision.collider.name == "PoolBall") {
            ballHitSound.Play();
        }
    }
}

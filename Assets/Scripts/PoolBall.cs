using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    public AudioSource ballHitSound;

    void OnCollisionEnter (Collision collision) {
        if (!ballHitSound.isPlaying && (collision.collider.name == "PoolBall" || collision.collider.name == "pool_stick")) {
            ballHitSound.Play();
        }
    }
}

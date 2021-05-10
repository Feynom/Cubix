using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    public float SoundVolume = 10f;
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player" ||
            collision.collider.tag == "Obstacle")
        {
            audioSource.volume = collision.impulse.magnitude * 0.01f * SoundVolume;
            audioSource.Play();
        }
    }

}

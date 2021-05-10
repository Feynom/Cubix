using UnityEngine;

public class RollingSound : MonoBehaviour
{
    public AudioSource audioSource;
    public float soundVolume = 50f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.name == "Platform")
        {
            audioSource.volume = Mathf.Clamp(GetComponent<Rigidbody>().velocity.magnitude * 0.001f * soundVolume, 0f, 200f);
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        audioSource.volume = Mathf.Lerp(audioSource.volume, 0, 2f);
    }
}

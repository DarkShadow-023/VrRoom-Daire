using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("Ball needs an Audio Source!");
        }

        if (audioSource != null && audioSource.clip == null)
        {
            Debug.LogError("Assign a bounce sound to the Audio Source!");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball hit: " + collision.gameObject.name);

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.PlayOneShot(audioSource.clip, 1f);
        }
    }
}
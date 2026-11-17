
using UnityEngine;

public class FindAudioListeners : MonoBehaviour
{
    void Start()
    {
        AudioListener[] listeners =
            FindObjectsByType<AudioListener>(
                FindObjectsSortMode.None
            );

        Debug.Log("Audio Listeners found: " + listeners.Length);

        foreach (AudioListener listener in listeners)
        {
            Debug.Log(
                "Listener found on: " +
                listener.gameObject.name,
                listener.gameObject
            );
        }
    }
}
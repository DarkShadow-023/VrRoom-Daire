
using UnityEngine;

public class JerryCanPour : MonoBehaviour
{
    public ParticleSystem fuelEffect;

    public void StartPouring(MonoBehaviour sender)
    {
        if (fuelEffect != null)
        {
            fuelEffect.Play();
        }

        Debug.Log("Jerry can is pouring!");
    }

    public void StopPouring(MonoBehaviour sender)
    {
        if (fuelEffect != null)
        {
            fuelEffect.Stop();
        }

        Debug.Log("Jerry can stopped pouring!");
    }
}

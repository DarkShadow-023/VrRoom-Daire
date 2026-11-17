using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 100f;

    [Tooltip("Try changing these if the reticle is invisible or spinning wrong")]
    public bool rotateX = false;
    public bool rotateY = true;
    public bool rotateZ = false;

    void Update()
    {
        float x = rotateX ? rotationSpeed * Time.deltaTime : 0f;
        float y = rotateY ? rotationSpeed * Time.deltaTime : 0f;
        float z = rotateZ ? rotationSpeed * Time.deltaTime : 0f;

        // Force local rotation relative to the XR Parent anchor
        transform.Rotate(x, y, z, Space.Self);
    }
}
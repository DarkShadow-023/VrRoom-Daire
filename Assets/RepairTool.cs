
using UnityEngine;

public class RepairTool : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object touched is a broken part
        BrokenPart brokenPart =
            other.GetComponentInParent<BrokenPart>();

        // If it is, destroy it
        if (brokenPart != null)
        {
            Destroy(brokenPart.gameObject);

            Debug.Log("Broken part removed!");
        }
    }
}

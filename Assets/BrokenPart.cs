
using UnityEngine;

public class BrokenPart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RepairTool tool = other.GetComponentInParent<RepairTool>();

        if (tool != null)
        {
            Destroy(gameObject);
            Debug.Log("Broken part repaired!");
        }
    }
}

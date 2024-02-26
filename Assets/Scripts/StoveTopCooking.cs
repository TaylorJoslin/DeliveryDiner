using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveTopCooking : MonoBehaviour
{
    [SerializeField] private string triggerLayer = "Cookable";
    [SerializeField] Material newMaterial;
    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionStay(Collision collision)
    {
        // Check if the triggering object is on the specified layer
        if (collision.gameObject.layer == LayerMask.NameToLayer(triggerLayer))
        {
            // Change the material of the object
            if (rend != null && newMaterial != null)
            {
                rend.material = newMaterial;
            }
        }
    }
}

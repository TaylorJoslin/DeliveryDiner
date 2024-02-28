using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperBag : MonoBehaviour
{
    
    [SerializeField] private GameObject storedObject;
    [SerializeField] private GameObject[] stored;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickupable"))
        {
            storedObject = other.gameObject;
        }
    }
}

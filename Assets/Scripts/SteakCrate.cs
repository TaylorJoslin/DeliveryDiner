using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SteakCrate : MonoBehaviour
{
    [SerializeField] GameObject SteakToSpawn;
    [SerializeField] Transform spawnPoint;
    [SerializeField] objectHold holdScript;
    private bool isCarrying;


    private void Start()
    {
        isCarrying = holdScript.Carrying;
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetMouseButtonDown(0))
        {
            Instantiate(SteakToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickupable") && !isCarrying)
        {
            Destroy(other.gameObject);
        }
    }
}

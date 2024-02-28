using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakCrate : MonoBehaviour
{
    [SerializeField] GameObject SteakToSpawn;
    [SerializeField] Transform spawnPoint;
    private bool isCarrying;


    private void Start()
    {
        isCarrying = GetComponent<objectHold>().GetIsCarrying();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetMouseButtonDown(0) && !isCarrying)
        {
            Instantiate(SteakToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

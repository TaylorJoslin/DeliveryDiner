using System.Collections;
using System.Collections.Generic;
using ItemTag;
using UnityEngine;

public class objectHold : MonoBehaviour
{
    public bool Carrying { get { return isCarrying; } } 

    private bool isCarrying = false;
    [SerializeField] private GameObject carriedObject;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float floatX;
    [SerializeField] private float floatY;
    [SerializeField] private float floatZ;

    private void Start()
    {
        //assigns transform of the player
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerStay(Collider other)
    {
        //pick up object if it is pickupable and player isn't holding anything
        if (Input.GetMouseButton(0) && other.CompareTag("Pickupable") && !isCarrying)
        {
            carriedObject = other.gameObject;
            isCarrying = true;
            carriedObject.GetComponent<Rigidbody>().isKinematic = true;
            carriedObject.transform.SetParent(playerTransform);
            
        }

        if (other.CompareTag("Pickupable"))
        {
            //other.GetComponent<Item>().ToString();
        }
    }

    private void Update()
    {
        //sets the potition of the held object infront of hte player
        if (isCarrying)
        {
            carriedObject.transform.localPosition = new Vector3(floatX, floatY, floatZ);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == carriedObject)
        {
            isCarrying = false;
            carriedObject.GetComponent<Rigidbody>().isKinematic = false;
            carriedObject.transform.SetParent(null);
            carriedObject = null;
        }
    }

    
}

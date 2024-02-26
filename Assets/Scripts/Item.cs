using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ItemTag
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private string Name;
       

        // Start is called before the first frame update
        void Start()
        {
           Name = gameObject.name;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


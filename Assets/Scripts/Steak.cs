using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ItemTag
{
   

    public class Steak : Item
    {
        [SerializeField] private TMP_Text nameText;
        

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                
            }
        }
    }
}


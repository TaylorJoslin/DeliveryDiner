using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBillboarding : MonoBehaviour
{
  
        [SerializeField] bool freezeXZAxis;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            //Controls if the sprite will look at the camera
            if (freezeXZAxis)
            {
                transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
            }
            else
            {
                transform.rotation = Camera.main.transform.rotation;
            }
        }
    }

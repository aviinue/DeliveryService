using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTracker : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) 
    {
        if (other.tag == "Target") 
        {
            void DestroyGameObject() 
            {
                Destroy();
            }
            
            //this.GetComponent<scoreScript>().score += 1;
        }
    }
}

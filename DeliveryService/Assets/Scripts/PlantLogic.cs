using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLogic : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Drop")
        {
            Destroy(target.gameObject);
            //score++;
        }
    }
}

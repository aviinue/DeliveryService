using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{
    public KeyCode drop;
    public GameObject myObject;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(drop))
        {
            Instantiate(myObject, transform.position + (transform.forward * 2), transform.rotation);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            Destroy(myObject);
            //this.GetComponent<scoreScript>().score += 1;
        }
    }
}

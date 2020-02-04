using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropController : MonoBehaviour
{
    public KeyCode drop;
    public GameObject myObject;
 
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(drop))
        {
            Instantiate(myObject, transform.position + (transform.forward * -2), transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

 }

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Healthy")
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Unhealthy")
        {
            Destroy(collision.gameObject);
        }
    }
}

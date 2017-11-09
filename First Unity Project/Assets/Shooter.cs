﻿using UnityEngine;

class Shooter : MonoBehaviour
{
    public Rigidbody prefab;
    public float speed = 10f;


    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var obj = (Rigidbody)Instantiate(this.prefab, transform.position, transform.rotation);
        obj.velocity = (transform.forward + transform.up / 2) * speed;
        }
    }
}

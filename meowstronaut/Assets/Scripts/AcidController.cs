﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Orbit();
    }

    void Orbit()
    {
        transform.RotateAround(rigidBody.transform.position, Vector3.forward, velocity * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // if hit by Kat, restart level
        if (other.gameObject.tag == "Player")
        {
            LevelController.RestartLevel();
        }
    }
}

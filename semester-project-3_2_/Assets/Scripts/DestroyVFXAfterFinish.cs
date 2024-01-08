using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVFXAfterFinish : MonoBehaviour
{
    private ParticleSystem particlesystem;

    private void Awake()
    {
        particlesystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (particlesystem.IsAlive())
            return;
        
        Destroy(gameObject);
    }
}

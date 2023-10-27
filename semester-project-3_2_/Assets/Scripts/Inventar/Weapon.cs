using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public MoverBase owner;
    public string displayName;

    public void GetEquippedBy(MoverBase owner)
    {
        this.owner = owner;
    }

    private void OnEnable()
    {
        PlayerAxisController controller = GetComponentInParent<PlayerAxisController>();
        if (controller != null)
            controller.AddWeapon(this);
    }

    private void OnDisable()
    {
        PlayerAxisController controller = GetComponentInParent<PlayerAxisController>();
        if (controller != null)
            controller.RemoveWeapon(this);
    }

    public virtual void StartShooting()
    {
        
    }
    
    public virtual void StopShooting()
    {
        
    }
    
    public virtual void Reload()
    {
        
    }
}

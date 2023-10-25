using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public MoverBase owner;

    public void GetEquippedBy(MoverBase owner)
    {
        this.owner = owner;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover mover;
    [SerializeField] private Mover playerMover;

    // Update is called once per frame
    void Update()
    {
        mover.SetMovementTarget(playerMover.GetPosition());
    }
}

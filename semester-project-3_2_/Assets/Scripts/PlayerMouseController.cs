using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    [SerializeField] private Mover mover;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            mover.SetMovementTarget(mouseWorldPosition);
        }

        if (Input.GetMouseButton(1))
        {
            mover.CancelMovement();
        }
    }
    
    
}

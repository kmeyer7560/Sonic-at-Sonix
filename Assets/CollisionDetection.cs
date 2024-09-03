using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public List<String> hand;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "stove")
        {
            
        }
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnCollisionExit(Collision other)
    {
        
    }
    
}


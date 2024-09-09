using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }


    void changeColor()
    {
        SpriteRenderer.color = new Color(1f, 10f, 1f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

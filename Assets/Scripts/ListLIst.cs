using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListList : MonoBehaviour
{
    
    public TMP_Text text;
    [SerializeField] public GameObject other;
    private string inv;
    private string nothing = String.Empty;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void changeInventory()
    {
        text.text = "";
        inv = other.GetComponent<Collisions>().inv;
        text.text = inv;
    }
    void Update()
    {
        changeInventory();
    }
}

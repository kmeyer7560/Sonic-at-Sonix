using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WRONG : MonoBehaviour
{
    // Start is called before the first frame update

    public void show()
    {
        gameObject.SetActive(true);
        WaitForSeconds wait = new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

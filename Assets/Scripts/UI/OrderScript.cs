using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI orderText;
    public static bool isFullOne;
    public float RadNum = 0f;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int minutes = Mathf.FloorToInt(time/60);
        int seconds = Mathf.FloorToInt(time % 60);
        if(isFullOne ==false)
        {
            if(seconds == 0)
            {
                RadNum = Random.Range(1,6);
                if(RadNum == 1)
                {
                    orderText.text = "Order 1: \nRaw Dog \nShake";
                }
                else if(RadNum == 2)
                {
                    orderText.text = "Order 2: \nChili Dog\n Toppings";
                }
                else if(RadNum == 3)
                {
                    orderText.text = "Order 3: \nShake";
                }
                else if(RadNum == 4)
                {
                    orderText.text = "Order 4 \nChili Dog";
                }
                else
                {
                    orderText.text = "Order 5: \nRaw Dog \nToppings";
                }
                isFullOne = true;
            }
        }
    }
}

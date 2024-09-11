using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointText;
    public int points = 0; 

    void Start()
    {
        pointText.text = "Points: " + 0;
    }
    public void completeOrder()
    {
        points++;
        pointText.text = "Points: " + points;
    }
}

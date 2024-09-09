using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class OrderScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI orderTextOne;
    [SerializeField] TextMeshProUGUI orderTextTwo;
    [SerializeField] TextMeshProUGUI orderTextThree;
    [SerializeField] TextMeshProUGUI orderTextFour;
    [SerializeField] TextMeshProUGUI orderTextFive;
    [SerializeField] TextMeshProUGUI orderTextSix;
    [SerializeField] TextMeshProUGUI orderTextSeven;
    [SerializeField] TextMeshProUGUI orderTextEight;
    [SerializeField] TextMeshProUGUI orderTextNine;
    [SerializeField] TextMeshProUGUI orderTextTen;
    public static int isFullOne = 0;
    public static int isFullTwo = 0;
    public static int isFullThree = 0;
    public static int isFullFour = 0;
    public static int isFullFive = 0;
    public static int isFullSix = 0;
    public static int isFullSeven = 0;
    public static int isFullEight = 0;
    public static int isFullNine = 0;
    public static int isFullTen = 0;
    public float RadNum = 0f;
    public float time;

    public static int[] isFull = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        if(seconds == 0)
        {
            checkMenu();
        }
    }

    public void checkMenu()
    {
        if (isFullOne == 0)
        {
            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextOne.text = "Order 1: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextOne.text = "Order 1: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextOne.text = "Order 1: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextOne.text = "Order 1; \nChili Dog";
            }
            else
            {
                orderTextOne.text = "Order 1: \nRaw Dog \nToppings";
            }
            isFullOne = (int)RadNum;
        }
        if (isFullTwo == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextTwo.text = "Order 2: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextTwo.text = "Order 2: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextTwo.text = "Order 2: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextTwo.text = "Order 2: \nChili Dog";
            }
            else
            {
                orderTextTwo.text = "Order 2: \nRaw Dog \nToppings";
            }
            isFullTwo = (int)RadNum;
        }
        if (isFullThree == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextThree.text = "Order 3: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextThree.text = "Order 3: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextThree.text = "Order 3: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextThree.text = "Order 3: \nChili Dog";
            }
            else
            {
                orderTextThree.text = "Order 3: \nRaw Dog \nToppings";
            }
            isFullThree = (int)RadNum;
        }
        if (isFullFour == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextFour.text = "Order 4: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextFour.text = "Order 4: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextFour.text = "Order 4: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextFour.text = "Order 4: \nChili Dog";
            }
            else
            {
                orderTextFour.text = "Order 4: \nRaw Dog \nToppings";
            }
            isFullFour = (int)RadNum;
        }
        if (isFullFive == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextFive.text = "Order 5: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextFive.text = "Order 5: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextFive.text = "Order 5: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextFive.text = "Order 5: \nChili Dog";
            }
            else
            {
                orderTextFive.text = "Order 5: \nRaw Dog \nToppings";
            }
            isFullFive = (int)RadNum;
        }

        if (isFullSix == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextSix.text = "Order 6: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextSix.text = "Order 6: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextSix.text = "Order 6: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextSix.text = "Order 6: \nChili Dog";
            }
            else
            {
                orderTextSix.text = "Order 6: \nRaw Dog \nToppings";
            }
            isFullSix = (int)RadNum;
        }
        if (isFullSeven == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextSeven.text = "Order 7: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextSeven.text = "Order 7: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextSeven.text = "Order 7: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextSeven.text = "Order 7: \nChili Dog";
            }
            else
            {
                orderTextSeven.text = "Order 7: \nRaw Dog \nToppings";
            }
            isFullSeven = (int)RadNum;
        }
        if (isFullEight == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextEight.text = "Order 8: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextEight.text = "Order 8: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextEight.text = "Order 8: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextEight.text = "Order 8: \nChili Dog";
            }
            else
            {
                orderTextEight.text = "Order 8: \nRaw Dog \nToppings";
            }
            isFullEight = (int)RadNum;
        }

        if (isFullNine == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextNine.text = "Order 9: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextNine.text = "Order 9: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextOne.text = "Order 9: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextNine.text = "Order 9: \nChili Dog";
            }
            else
            {
                orderTextNine.text = "Order 9: \nRaw Dog \nToppings";
            }
            isFullNine = (int)RadNum;
        }
        if (isFullTen == 0)
        {

            RadNum = Random.Range(1, 6);
            if (RadNum == 1)
            {
                orderTextTen.text = "Order 10: \nRaw Dog \nSlushee";
            }
            else if (RadNum == 2)
            {
                orderTextTen.text = "Order 10: \nChili Dog\n Toppings";
            }
            else if (RadNum == 3)
            {
                orderTextTen.text = "Order 10: \nSlushee";
            }
            else if (RadNum == 4)
            {
                orderTextTen.text = "Order 10: \nChili Dog";
            }
            else
            {
                orderTextTen.text = "Order 10: \nRaw Dog \nToppings";
            }
            isFullTen = (int)RadNum;
        }
    }
}

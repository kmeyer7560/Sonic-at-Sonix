using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.Collections;

public class OrderScript : MonoBehaviour
{
    //texts this should each be tied to a different order object
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
    //random
    public float RadNum = 0f;
    public float time;
    public static int[] isFull = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //the minutes part of the timer
        int minutes = Mathf.FloorToInt(time / 60);
        //the seconds part of the timer
        int seconds = Mathf.FloorToInt(time % 60);

        //when check menu is called
        if (seconds == 0)
        {
            checkMenu();
        }
    }

    public void checkMenu()
    {
        /*
        for (int i = 0; i < 10; i++)
        {
            if (isFull[i] == 0 && i != 9)
            {
                isFull[i] = isFull[i + 1];
                isFull[i + 1] = 0;
            }
        }
        */


        //can only generate new menu if it doesn't have a radnum set
        if (isFullOne == 0)
        {
            GenOne();
        }
        if (isFullTwo == 0)
        {
            GenTwo();
        }
        if (isFullThree == 0)
        {
            GenThree();
        }
        if (isFullFour == 0)
        {
            GenFour();
        }
        if (isFullFive == 0)
        {
            GenFive();
        }

        if (isFullSix == 0)
        {
            GenSix();
        }
        if (isFullSeven == 0)
        {
            GenSeven();
        }
        if (isFullEight == 0)
        {
            GenEight();
        }
        if (isFullNine == 0)
        {
            GenNine();
        }
        if (isFullTen == 0)
        {
            GenTen();
        }
    }
    //seperate generation methods so you can call them one at a time
    public void GenOne()
    {
        //randomly generates order text
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
            orderTextOne.text = "Order 1: \nChili Dog";
        }
        else
        {
            orderTextOne.text = "Order 1: \nRaw Dog \nToppings";
        }
        //saves random number
        isFullOne = (int)RadNum;
    }
    public void GenTwo()
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
    public void GenThree()
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
    public void GenFour()
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
    public void GenFive()
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
    public void GenSix()
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
    public void GenSeven()
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
    public void GenEight()
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
    public void GenNine()
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
    public void GenTen()
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
            orderTextTen.text = "Order 10:\nRaw Dog \nToppings";
        }
        isFullTen = (int)RadNum;
    }
}

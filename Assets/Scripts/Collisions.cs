using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

public class Collisions : MonoBehaviour
{
    [SerializeField]
    List<string> inventory; //makes the inventory
    [SerializeField]
    private GameObject ListList;

    private List<string> orderList;

    private GameObject orders;

    private GameObject wrong;

    private int orderNum;

    public string inv;
    
    

    //NOTE: just make sure every station has a boxcollider2D, and has the proper tag. everything else is super straightforward! Hello from 1 am
    void OnCollisionEnter2D(Collision2D other)
    {

        //note, if you feel the need to make anohter thing called "fulldog" to show you have a full hotdog,
        //dont do it. just check if theres a cookdog and a cookbread, waaay easier cuh..... condements not added yet.
        if (other.gameObject.tag == "hotdog") //make sure to set tags! -> checks which station it is
        {
            if (!inventory.Contains("hotdog") && !inventory.Contains("cookdog")) //checks if there is already one, and checks if there is no cooked hotdog either. 
                {
                    inventory.Add("hotdog"); //adds duh
                }
                    
            }

        if (other.gameObject.tag == "stove") //checks if touching stove
        {
            if (!inventory.Contains("cookdog") && inventory.Contains("hotdog")) //makes sure you dont already have one
            {
                inventory.Remove("hotdog"); //gets rid of the hotdog
                inventory.Add("cookdog"); // gives a cooked dog (duh)
            }

            if (!inventory.Contains("cookbread") && inventory.Contains("bread"))
            {
                inventory.Remove("bread");
                inventory.Add("cookbread");
            }
            
        }

        if (other.gameObject.tag == "pot" && inventory.Contains("chili"))
        {
            inventory.Remove("chili");
            inventory.Add("cookchili");
        }

        if (other.gameObject.tag == "bread") //breadstuff
        {
            if (!inventory.Contains("bread") && !inventory.Contains("cookbread"))
            {
                inventory.Add("bread");
            }
        }

        if (other.gameObject.tag == "chili")
        {
            if (!inventory.Contains("chili") && !inventory.Contains("cookchili"))
            {
                inventory.Add("chili");
            }
        }

        if (other.gameObject.tag == "slushee")
        {
            if (!inventory.Contains("slushee"))
            {
                inventory.Add("slushee");
            }
        }

        if (other.gameObject.tag == "cond")
        {
            if (!inventory.Contains("condements"))
            {
                inventory.Add("condements");
            }
        }

        if (other.gameObject.tag == "outWindow")
        {
            checkInv();
            clearInventory();
        }
        
        
        
        
        
        
        
        
        
        
        
        changeInv();




    }

    void checkInv()
    {
        orderNum = 0;
        orderList.Clear();
        if (orders.GetComponent<OrderScript>().RadNum == 1)
        {
            orderList.Add("hotdog");
            orderList.Add("slushee");
            orderNum = 1;
        }

        else if (orders.GetComponent<OrderScript>().RadNum == 2)
        {
            orderList.Add("cookbread");
            orderList.Add("cookdog");
            orderList.Add("cookchili");
            orderList.Add("condements");
            orderNum = 2;
        }

        else if (orders.GetComponent<OrderScript>().RadNum == 3)
        {
            orderList.Add("slushee");
            orderNum = 3;
        }
        
        else if (orders.GetComponent<OrderScript>().RadNum == 4)
        {
            orderList.Add("cookbread");
            orderList.Add("cookdog");
            orderList.Add("cookchili");
            orderNum = 4;
        }

        else 
        {
            orderList.Add("hotdog");
            orderList.Add("condements");
            orderNum = 5;
        }


        if (orderNum == 1)
        {
            if (inventory.Contains("hotdog") && inventory.Contains("slushee") && !inventory.Contains("cookbread") && !inventory.Contains("cookchili") && !inventory.Contains("condements") && !inventory.Contains("bread") && !inventory.Contains("chili") && !inventory.Contains("cookdog"))
            {
                orders.GetComponent<Points>().completeOrder();
            }
        }
        
        else if (orderNum == 2)
        {
            if (inventory.Contains("Cookdog") && inventory.Contains("cookbread") && inventory.Contains("cookchili") &&
                inventory.Contains("condements") && !inventory.Contains("bread") && !inventory.Contains("chili") &&
                !inventory.Contains("hotdog") && !inventory.Contains("slushee"))
            {
                orders.GetComponent<Points>().completeOrder();
            }
        }
        
        else if (orderNum == 3)
        {
            if (inventory.Contains("slushee") && !inventory.Contains("cookdog") && !inventory.Contains("hotdog") &&
                !inventory.Contains("bread") && !inventory.Contains("cookbread") && !inventory.Contains("chili") &&
                !inventory.Contains("cookchili") && !inventory.Contains("condements"))
            {
                orders.GetComponent<Points>().completeOrder();
            }
        }
        
        else if (orderNum == 4)
        {
            if (inventory.Contains("cookbread") && inventory.Contains("cookdog") && inventory.Contains("cookchili") &&
                !inventory.Contains("condements") && !inventory.Contains("bread") && !inventory.Contains("hotdog") &&
                !inventory.Contains("chili") && !inventory.Contains("slushee"))
            {
                orders.GetComponent<Points>().completeOrder();
            }
        }
        
        else if (inventory.Contains("hotdog") && inventory.Contains("condements") && !inventory.Contains("cookdog") &&
                 !inventory.Contains("cookbread") && !inventory.Contains("bread") && !inventory.Contains("slushee") &&
                 !inventory.Contains("chili") && !inventory.Contains("cookchili"))
        {
            orders.GetComponent<Points>().completeOrder();
        }

        else
        {
            wrong.GetComponent<WRONG>().show();
        }
        
    }

    public void clearInventory() //just to clear the inventory when the order is finished.
    {
        inventory.Clear();
    }

    public void changeInv()
    {
        inv = "";
        for (int i = 0; i < inventory.Count; i++)
        {
            inv += inventory[i];
            inv += "\n";
        }
        Debug.Log(inv);
        ListList.GetComponent<ListList>().changeInventory();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    
}

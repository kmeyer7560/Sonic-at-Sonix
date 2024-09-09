using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collisions : MonoBehaviour
{
    [SerializeField]
    List<string> inventory; //makes the inventory 

    //NOTE: just make sure every station has a boxcollider2D, and has the proper tag. everything else is super straightforward!
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




    }

    public void clearInventory() //just to clear the inventory when the order is finished.
    {
        inventory.Clear();
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

using System.Collections.Generic;
using UnityEngine;

public class ItemsDatabase : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    void Awake()
    {
        // Create your game's item definitions here
        // Add them to items
        Item employeeBadge = new Item("Employee Badge", "employee_badge", "Main Items", "This is your Employee Badge. You must use this to come into the office or access certain employee restricted areas.", false, false, false, false, false, false);
        items.Add(employeeBadge);
        Item coffee = new Item("Coffee", "coffee", "Drinks", "It's a coffee.", true, false, true, true, true, true);
        items.Add(coffee);
    }

    void Start()
    {
        Item coffee = GetItemById("coffee");
    }

    public Item GetItemById(string id)
    {
        // Search through items
        // Return the item whose Id matches
        // Return null if nothing matches
        foreach (Item item in items){
            if (item.Id == id)
            {
                Debug.Log(item.Description);
                return item;
            }
        }
        return null; 
    }
}
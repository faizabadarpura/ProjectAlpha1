using System.Collections.Generic;
using UnityEngine;

public class ItemsDatabase : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    void Awake()
    {
        // Create your game's item definitions here
        // Add them to items
        Item employeeBadge = new Item("Employee Badge", "employee_badge", "Main Items", "This is your Employee Badge. You must use this to come into the office or access certain employee areas.", false, false, false, false, false, false);
        items.Add(employeeBadge);
        Item coffee = new Item("Coffee", "coffee", "Drinks", "It's a coffee.", true, false, true, true, true, true);
        items.Add(coffee);
        Item icedCoffee = new Item("Iced Coffee", "iced_coffee", "Drinks", "It'a an iced coffee.", true, false, true, true, true, true);
        items.Add(icedCoffee);
        Item coffeeMug = new Item("Coffee Mug", "coffee_mug", "Objects", "An empty mug.", true, false, false, true, false, false);
        items.Add(coffeeMug);
        Item proteinBar = new Item("Protein Bar", "protein_bar", "Snacks", "Protein Bars help relieve a good amount of hunger. However, eating too many can make you feel sick.", true, true, true, true, true, false);
        items.Add(proteinBar);
        Item workLaptop = new Item("Work Laptop", "work_laptop", "Main Items", "This is your work laptop. Use this to track your employee stats and to get some work done.", false, false, false, false, false, false);
        items.Add(workLaptop);
        Item executiveBadge = new Item("Executive Badge", "executive_badge", "Secondary Items", "This is your Executive Employee Badge. You must use this to come into the office or access certain restricted areas.", false, false, false, false, false, false);
        items.Add(executiveBadge);
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
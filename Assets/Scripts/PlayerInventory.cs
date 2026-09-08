using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<Item> inventory = new List<Item>();
    [SerializeField] private ItemsDatabase itemsDatabase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Item employeeBadge = itemsDatabase.GetItemById("employee_badge");
        if (employeeBadge != null)
        {
            AddItem(employeeBadge);
            if(HasItem(employeeBadge) == true)
            {
                Debug.Log("Player has Employee Badge.");
            }
            else
            {
                Debug.Log("Employee Badge not added.");
            }
        }
}
    public void AddItem(Item item) {
        inventory.Add(item);
        Debug.Log(item.Name + " added to Player Inventory");
    }
    public void RemoveItem(Item item) {
        inventory.Remove(item);
    }
    public bool HasItem(Item item) {
        return inventory.Contains(item);
    }
    public void ListItems() {
        foreach (Item item in inventory)
        {
            Debug.Log(item.Name);
        }
    }
    // void SortItems()
    //{
    //    inventory.Sort();
    //}
}
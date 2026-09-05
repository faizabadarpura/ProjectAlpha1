using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<Item> inventory = new List<Item>();
    private Item employeeBadge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        employeeBadge = new Item("Employee Badge", "employee_badge", "Main Items", "This is your Employee Badge. You must use this to come into the office or access certain employee restricted areas.", false, false, false, false, false, false);

        AddItem(employeeBadge);
}
    public void AddItem(Item item) {
        inventory.Add(item);
    }
    public void RemoveItem(Item item) {
        inventory.Remove(item);
    }
    public bool HasItem(Item item) {
        return inventory.Contains(item);
    }
    //public void ListItems() { }
    // void SortItems()
    //{
    //    inventory.Sort();
    //}
}
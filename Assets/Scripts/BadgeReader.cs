using UnityEngine;

public class BadgeReader : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemsDatabase itemsDatabase;
    [SerializeField] private DoorAccess door;
    public bool GrantBasicAccess()
    {
        Item employeeBadge = itemsDatabase.GetItemById("employee_badge");
        if (inventory.HasItem(employeeBadge) == true) 
        {
            return true;
        }
        return false;
    }
    public bool GrantRestrictedAccess()
    {
        Item executiveBadge = itemsDatabase.GetItemById("executive_badge");
        if (inventory.HasItem(executiveBadge) == true)
        {
            return true;
        }
        return false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           int accesslevel = door.GrantDoorAccess();
            if (accesslevel > 0) {
                door.OpenDoor();            
            }
        }
    }
}

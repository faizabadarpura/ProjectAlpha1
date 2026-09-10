using UnityEngine;

public class BadgeReader : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemsDatabase itemsDatabase;
    [SerializeField] private DoorAccess door;
    private bool playerInRange = false;
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ScanItem();
        }
    }
    void ScanItem()
    {
        Item heldItem = inventory.EquippedItem;

        if (heldItem == null)
        {
            Debug.Log("You aren't holding anything.");
            return;
        }

        Debug.Log("Scanning: " + heldItem.Name);
        if (heldItem.Id == "employee_badge")
        {
            door.OpenDoor();
        }
        else
        {
            Debug.Log("Access denied.");
        }
    }
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
            playerInRange = true;
            Debug.Log("Press E to use your Employee Badge.");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}

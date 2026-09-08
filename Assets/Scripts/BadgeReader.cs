using UnityEngine;

public class BadgeReader : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemsDatabase itemsDatabase;
    public bool GrantBasicAccess()
    {
        Item employeeBadge = itemsDatabase.GetItemById("employee_badge");
        if (inventory.HasItem(employeeBadge) == true) {
            return true;
        }
        return false;
    }
}

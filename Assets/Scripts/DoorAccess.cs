using UnityEngine;

public class DoorAccess : MonoBehaviour
{
    [SerializeField] private BadgeReader badgeReader;
    [SerializeField] private PlayerInventory inventory;
    public int GrantDoorAccess()
    {
        if (badgeReader.GrantRestrictedAccess() == true)
        {
            Debug.Log("Access 2");
            return 2;//for basic badge
        }
        else if (badgeReader.GrantBasicAccess() == true)
        {
            Debug.Log("Access 1");
            return 1;//for executive badge
        }
        else 
        {
            Debug.Log("No Access");
            return 0;//no badge
        }
    }
}

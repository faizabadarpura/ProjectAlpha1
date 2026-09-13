using UnityEngine;

public class BadgeReaderExit : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemsDatabase itemsDatabase;
    [SerializeField] private DoorAccess door;
    private bool playerInRange = false;

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            door.OpenDoor();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
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

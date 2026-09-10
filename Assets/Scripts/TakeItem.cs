using UnityEngine;

public class TakeItem : MonoBehaviour
{
    [SerializeField] private string itemId;
    [SerializeField] private ItemsDatabase itemsDatabase;
    [SerializeField] private PlayerInventory inventory;
    private bool playerInRange = false;
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PickUp(inventory);
        }
    }
    public void PickUp(PlayerInventory playerInventory)
    {
        Item item = itemsDatabase.GetItemById(itemId);

        if (item != null)
        {
            playerInventory.AddItem(item);

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Press E to take.");
        }
    }
}

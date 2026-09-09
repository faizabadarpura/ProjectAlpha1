using UnityEngine;

public class DoorAccess : MonoBehaviour
{
    [SerializeField] private BadgeReader badgeReader;
    [SerializeField] private PlayerInventory inventory;
    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool isOpen = false;
    private float speed = 2.0f;
    private float openTimer = 0f;
    [SerializeField] private float closeDelay = 3f;
    [SerializeField] private Vector3 openOffset;
    void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + openOffset;
    }
    void Update()
    {
        if (isOpen)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, speed * Time.deltaTime);
            openTimer += Time.deltaTime;
            if (openTimer >= closeDelay)
            {
                isOpen = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(
                transform.position,
                closedPosition,
                speed * Time.deltaTime
            );
        }
    }
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
    public void OpenDoor()
    {
        isOpen = true;
        openTimer = 0f;
    }
}

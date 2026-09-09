using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private double money = 1574.60;
    public double Money { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Money = money;
    }
    public void IncreaseMoney(double amount)
    {
        Money += amount;
        Debug.Log("Current Balance: " + Money);
    }
    public void DecreaseMoney(double amount)
    {
        Money -= amount;
        Debug.Log("Current Balance: " + Money);
    }
}

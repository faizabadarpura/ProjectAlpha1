using JetBrains.Annotations;
using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;

public class PlayerHunger : MonoBehaviour
{
    [SerializeField] private int hunger = 90;

    public int Hunger { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hunger = hunger;
    }
    public void IncreaseHunger (int amount)
    {
        Hunger += amount;
        Hunger = Mathf.Clamp(Hunger, 0, 100);
        Debug.Log("Hunger: " + Hunger);
    }
    public void DecreaseHunger (int amount)
    {
        Hunger -= amount;
        Hunger = Mathf.Clamp(Hunger, 0, 100);
        Debug.Log("Hunger: " + Hunger);
    }
}

using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerReputation : MonoBehaviour
{
    [SerializeField] private int reputation = 50;

    public int Reputation { get; private set; }
    public string reputationStat { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Reputation = reputation;
        UpdateReputationState();
    }
    public void IncreaseReputation(int amount)
    {
        Reputation += amount;

        Reputation = Mathf.Clamp(Reputation, 0, 100);

        UpdateReputationState();
    }
    public void DecreaseReputation(int amount)
    {
        Reputation -= amount;

        Reputation = Mathf.Clamp(Reputation, 0, 100);

        UpdateReputationState();
    }

    private void UpdateReputationState()
    {
        if (Reputation <= 25)
        {
            reputationStat = "Horrible";
        }
        else if (Reputation <= 50)
        {
            reputationStat = "Bad";
        }
        else if (Reputation <= 75)
        {
            reputationStat = "Good";
        }
        else
        {
            reputationStat = "Prestige";
        }

        Debug.Log(
            "Reputation: " + Reputation +
            " | Status: " + reputationStat
        );
    }

}

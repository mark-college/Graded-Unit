using UnityEngine;

public class ShopKeeper : MonoBehaviour
{
    [Header("References")]
    public PlayerCurrency playerCurrency;
    public PlayerStats playerStats;

    [Header("Costs")]
    public int healthCost = 5;
    public int damageCost = 5;

    [Header("Upgrade Values")]
    public float healthIncrease = 2f;
    public float damageIncrease = 1f;

    public bool BuyHealthUpgrade()
    {
        if (playerCurrency == null || playerStats == null)
            return false;

        if (playerCurrency.SpendCoins(healthCost))
        {
            playerStats.IncreaseHealth(healthIncrease);
            Debug.Log("Health upgraded!");
            return true;
        }

        Debug.Log("Not enough coins for health upgrade.");
        return false;
    }

    public bool BuyDamageUpgrade()
    {
        if (playerCurrency == null || playerStats == null)
            return false;

        if (playerCurrency.SpendCoins(damageCost))
        {
            playerStats.IncreaseDamage(damageIncrease);
            Debug.Log("Damage upgraded!");
            return true;
        }

        Debug.Log("Not enough coins for damage upgrade.");
        return false;
    }
}
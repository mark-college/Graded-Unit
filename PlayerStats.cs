using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Stats")]
    public float maxHealth = 10f;
    public float currentHealth;

    public float damage = 1f;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void IncreaseHealth(float amount)
    {
        maxHealth += amount;
        currentHealth += amount;

        Debug.Log("Max health increased to: " + maxHealth);
    }

    public void IncreaseDamage(float amount)
    {
        damage += amount;

        Debug.Log("Damage increased to: " + damage);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Player died");
            // handle death later
        }
    }
}
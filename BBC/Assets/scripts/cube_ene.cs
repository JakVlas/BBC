using UnityEngine;

public class Target: MonoBehaviour
{
    private int health = 2;

    public void TakeDamage(int amount)
    {
        health -=amount;

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);    
    }
}
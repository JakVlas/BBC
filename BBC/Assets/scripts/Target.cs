using UnityEngine;

public class Target: MonoBehaviour
{
    public int health;

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
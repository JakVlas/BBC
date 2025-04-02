using UnityEngine;
using System.Collections;

public class Target: MonoBehaviour
{
    private int health = 2;
    Rigidbody m_Rigidbody;
    Vector3 m_ZAxis;        

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ;
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX;
    }
    

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
        m_Rigidbody.constraints = RigidbodyConstraints.None;
        StartCourtine(Dying());
        Destroy(gameObject); 

    }
    IEnumerator Dying()
    {

        yield return new WaitForSeconds(1);
   
    }
}
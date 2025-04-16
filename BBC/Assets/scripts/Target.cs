using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Target: MonoBehaviour
{
    public int health = 2;
    Rigidbody m_Rigidbody;
    Vector3 m_ZAxis;
    Vector3 velocity; 
    public GameObject cil;
    public Vector3 targetPosition;
    public float smoothTime = 0.5f;
    public float speed;
    public int damage;
       

    void Start()
    {
        /*m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ;
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX;
*/
        cil =   GameObject.Find("Player");
    }
    
    void Update()//pohyb za hracem
    {       
        targetPosition = cil.transform.position;
        transform.LookAt(cil.transform);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
    }

    public void TakeDamage(int amount)
    {
        health -=amount;
        Debug.Log(health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        /*m_Rigidbody.constraints = RigidbodyConstraints.None;*/
        //StartCourtine(Dying());
        Destroy(gameObject); 

    }
}
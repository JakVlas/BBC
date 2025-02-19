using UnityEngine;

public class gun_mechanics : MonoBehaviour
{
    public int damage;
    public int zasobnik;
    public int bullets_per_second;
    public int range;
    public Camera PlayerCamera;
    private bool canFire;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {   
        canFire = false;
        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
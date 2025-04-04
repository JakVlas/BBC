using UnityEngine;
using System.Collections;

public class gun_mechanics : MonoBehaviour
{
    public int damage;
    public int bullets_per_second;
    public int range;
    public Camera PlayerCamera;
    private bool canFire = true;
    public GameObject hitmarker;
    public float distance;


    void Start()
    {
        HitDisabled();
        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")&& canFire)
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
                HitActive();
            }
        }
        StartCoroutine(FireRate());

    }

    IEnumerator FireRate()
    {   
        float TimeForNextShot = 1/bullets_per_second;
        yield return new WaitForSeconds(TimeForNextShot);
        HitDisabled();
        canFire = true;
    }

    


    private void HitActive(){
        hitmarker.SetActive(true);
    }

    private void HitDisabled(){
        hitmarker.SetActive(false);
    }
}
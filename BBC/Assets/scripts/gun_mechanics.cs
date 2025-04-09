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
    public int weapon_mode;


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

        if(Input.GetButtonDown("Fire3"))
        {
            Change_weapon_mode();
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

    void Change_weapon_mode()
    {
        if(weapon_mode != 2){
            weapon_mode += 1;
        }
        else{
            weapon_mode = 0;
        }
    

        switch(weapon_mode)
        {
            case 0:
                damage = 2;
                range = 100;
                bullets_per_second = 5;
                break;

            case 1:
                damage = 5;
                range = 5;
                bullets_per_second = 2; 
                break;

            case 2:
                damage = 1;
                range = 10;
                bullets_per_second = 10;
                break;
        }

        Debug.Log("zmena na");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour
{   
    public GameObject uiua;   
   private UI_script uscript = uiua.GetComponent<UI_script>();
   // int zivot = uiua.UI_script.zivoty_hrace;
    void OnCollisionEnter(Collision collision)
    {   
        GameObject kdoKoliduje = collision.collider.gameObject;

        if (kdoKoliduje.tag == "Enemy")
        {   
            Target nepritelScript = collision.gameObject.GetComponent<Target>();
            if (nepritelScript != null) 
                {

               // zivot -= nepritelScript.damage;
                 // UI.GetComponent<UI_script>.zivoty_hrace -= nepritelScript.damage;
                }
        }
    }
 
 
}

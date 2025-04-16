using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour
{   

    public void player_zdravi()
    {
        int zivoty_hrace;
    }
    void Start()
    {   
        player_zdravi();
        zivoty_hrace = 100;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {   
        GameObject kdoKoliduje = collision.collider.gameObject;

        if (kdoKoliduje.tag == "nepritel")
        {   
            Target nepritelScript = collision.gameObject.GetComponent<Target>();
            if (nepritelScript != null) 
                {
                    zivoty_hrace -= nepritelScript.damage;
                }
        }
    }

    void Update()
    {
        if (zivoty_hrace == 0)
            {
                Zmena_sceny("smrt");
            }
    }

    public void Zmena_sceny(string scena)
    {
        SceneManager.LoadScene(scena);
    }
}

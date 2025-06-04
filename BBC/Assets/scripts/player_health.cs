using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour
{   

    static public int zivoty_hrace;

    void Start()
    {   
        zivoty_hrace = 100;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {   
        GameObject kdoKoliduje = collision.collider.gameObject;

        if (kdoKoliduje.tag == "Enemy")
        {   
            Target nepritelScript = collision.gameObject.GetComponent<Target>();
            if (nepritelScript != null) 
                {
                    Debug.Log("chcipni");
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

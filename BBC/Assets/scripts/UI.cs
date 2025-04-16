using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zivoty : MonoBehaviour
{
    Target target = GameObject.Find("Player");
    player_zdravi cs = target.GetComponent<player_zdravi>();
    int zivoty_hrace = cs.zivoty_hrace;

    public Slider healthbar;
    public TMP_Text health;
    

    public void Zmena_sceny(string scena){
        SceneManager.LoadScene(scena);
    }
    // Update is called once per frame
    void Update()
    {


        health.SetText(zivoty_hrace.ToString());
        healthbar.value = zivoty_hrace;
    }
}

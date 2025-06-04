using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zivoty : MonoBehaviour
{
    public Slider healthbar;
    public TMP_Text health;


    public void Zmena_sceny(string scena){
        SceneManager.LoadScene(scena);
    }
    // Update is called once per frame
    void Update()
    {
        health.SetText(player_health.zivoty_hrace.ToString());
        healthbar.value = player_health.zivoty_hrace;
    }
}

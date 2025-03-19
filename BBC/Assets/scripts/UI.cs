using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zivoty : MonoBehaviour
{

    public int zivoty_hrace;
    public Slider healthbar;
    public TMP_Text health;
    
    // Start is called before the first frame update
    void Start()
    {
     zivoty_hrace = 100;   
    }

    public void Zmena_sceny(string scena){
        SceneManager.LoadScene(scena);
    }
    // Update is called once per frame
    void Update()
    {
        if (zivoty_hrace == 0)
        {
            Zmena_sceny("smrt");
        }

        health.SetText(zivoty_hrace.ToString());
        healthbar.value = zivoty_hrace;
    }
}

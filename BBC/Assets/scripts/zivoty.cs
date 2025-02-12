using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        if (zivoty_hrace == 0)
        {
            UnityEngine.Debug.Log("zmiz");
        }

        health.SetText(zivoty_hrace.ToString());
        healthbar.value = zivoty_hrace;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zivoty : MonoBehaviour
{

    public int zivoty_hrace;
    
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
    }
}

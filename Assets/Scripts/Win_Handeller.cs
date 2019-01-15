using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_Handeller : MonoBehaviour {

    public HP boxer1;
    public HP boxer2;


    public Text winone;
    public Text wintwo;
    // Use this for initialization
    private void Awake()
    {

        winone.gameObject.SetActive(false);
        wintwo.gameObject.SetActive(false);

    }

    private void Update()
    {
        if (boxer1.hp == 0)
        {
            wintwo.gameObject.SetActive(true);

        }

        if (boxer2.hp == 0)
        {
            winone.gameObject.SetActive(true);

        }
    }
}

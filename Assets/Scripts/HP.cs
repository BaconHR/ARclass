using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int hp = 100;
    public int dg = 10;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (hp <= 0)
        {
            Debug.Log("Die");
        }
	}
    public void damage ()
    {
        hp -= dg;
        Debug.Log("current:" + hp);
    }
    void hleath ()
    {

    }
}

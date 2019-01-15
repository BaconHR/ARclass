using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            HP a = other.GetComponentInChildren<HP>();

            if (a != null)
            {
                a.damage();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public GameObject mur;
    public GameObject interrupteur;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Kart")
        {
            Destroy(mur);
            Destroy(interrupteur);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

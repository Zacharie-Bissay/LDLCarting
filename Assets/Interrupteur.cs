using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public GameObject mur;
    public GameObject interrupteur;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Kart");
        {
            //Détruire le gameObject du mur
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

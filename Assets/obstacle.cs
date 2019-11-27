using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Life lifeComponent = other.gameObject.GetComponent<Life>();
        if (lifeComponent!= null)
        {
            if (other.gameObject.name =="Kart")
            {
                lifeComponent.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}

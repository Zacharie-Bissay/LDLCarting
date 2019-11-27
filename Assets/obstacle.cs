using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Life lifeComponent = other.gameObject.GetComponent<Life>();
        if (lifeComponent ! = null)
        {
            Life = GetComponent<>()
        }
    }
}

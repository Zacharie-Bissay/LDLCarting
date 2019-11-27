using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int lives;

    public TMPro.TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = lives.ToString();
    }

    public void TakeDamage()
    {
        lives -= 1;
    }
    // Update is called once per frame
    void Update()
    {
        text.text = lives.ToString();
    }
}

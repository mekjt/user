using System;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int Bhp = 10;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bhp <= 0)
        {
            Application.Quit();
        }
    }
}

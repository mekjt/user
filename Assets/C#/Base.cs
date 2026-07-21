using System;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int Bhp = 10;
    //Enemy Eneobj = collision.gameObject.GetComponent<Enemy>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

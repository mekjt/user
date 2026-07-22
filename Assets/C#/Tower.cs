using UnityEngine;

public class Tower : MonoBehaviour
{
    int Ehp;
    Enemy enemytrigger;
    public Towerall towerall;
    public Towerall.allTowernumbers allTowernumbers;

    void OnTriggerEnter(Collider other)
    {
        enemytrigger = other.GetComponent<Enemy>();


    }
}